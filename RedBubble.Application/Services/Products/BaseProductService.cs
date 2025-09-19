using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Services;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedBubble.Application.Interfaces.Products;


namespace RedBubble.Application.Services
{
    public class BaseProductService : IBaseProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileService _fileService;
        private readonly IImageService _imageService;
        public BaseProductService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IFileService fileService,
            IImageService imageService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileService = fileService;
            _imageService = imageService; 
        }

        public async Task<IEnumerable<BaseProductListDto>> GetAllBaseProductsAsync()
        {
            var repository = _unitOfWork.GetRepository<BaseProduct, int>();
            var products = await repository.GetAll()
                .Include(p => p.Category)
                .Include(p => p.Templates.Where(t => t.IsActive && t.IsPrimary))
                .Include(p => p.ProductVariants.Where(v => v.IsActive))
                .Where(p => p.IsActive)
                .OrderBy(p => p.Name)
                .ToListAsync();

            return _mapper.Map<IEnumerable<BaseProductListDto>>(products);
        }

        public async Task<BaseProductDto?> GetBaseProductByIdAsync(int id)
        {
            var repository = _unitOfWork.GetRepository<BaseProduct, int>();
            var product = await repository.GetAll()
                .Include(p => p.Category)
                .Include(p => p.PrintAreas.Where(pa => pa.IsActive))
                .Include(p => p.Templates.Where(t => t.IsActive))
                .Include(p => p.AvailableSizes.Where(s => s.IsActive))
                    .ThenInclude(s => s.Size)
                .Include(p => p.AvailableColors.Where(c => c.IsActive))
                    .ThenInclude(c => c.Color)
                .FirstOrDefaultAsync(p => p.Id == id);

            return product != null ? _mapper.Map<BaseProductDto>(product) : null;
        }

        public async Task<BaseProductDto> CreateBaseProductAsync(CreateBaseProductDto createProductDto, string createdBy)
        {
            // Improved validation
            await ValidateCreateDtoAsync(createProductDto);

            // Validate that category exists
            var categoryRepo = _unitOfWork.GetRepository<Category, int>();
            var categoryExists = await categoryRepo.GetAll()
                .AnyAsync(c => c.Id == createProductDto.CategoryId && c.IsActive);
            if (!categoryExists)
            {
                throw new ArgumentException("Selected category does not exist or is inactive.");
            }

            // Validate sizes and colors exist
            await ValidateSizesAndColorsAsync(createProductDto.AvailableSizeIds, createProductDto.AvailableColorIds);

            // Map to entity
            var baseProduct = _mapper.Map<BaseProduct>(createProductDto);
            baseProduct.CreatedBy = createdBy;
            baseProduct.CreatedOn = DateTime.UtcNow;
            baseProduct.LastModifiedBy = createdBy;
            baseProduct.LastModifiedOn = DateTime.UtcNow;
            baseProduct.IsActive = true;

            var repository = _unitOfWork.GetRepository<BaseProduct, int>();
            await repository.AddAsync(baseProduct);
            await _unitOfWork.CompleteAsync();

            // Handle related entities after base product ID is generated
            await CreatePrintAreasAsync(baseProduct, createProductDto.PrintAreas);
            await CreateTemplatesAsync(baseProduct, createProductDto.Templates);
            await CreateAvailableSizesAsync(baseProduct, createProductDto.AvailableSizeIds);
            await CreateAvailableColorsAsync(baseProduct, createProductDto.AvailableColorIds);
            await _unitOfWork.CompleteAsync();

            return await GetBaseProductByIdAsync(baseProduct.Id)
                ?? throw new InvalidOperationException("Failed to retrieve created product.");
        }

        public async Task<BaseProductDto> UpdateBaseProductAsync(UpdateBaseProductDto updateProductDto, string modifiedBy)
        {
            await ValidateUpdateDtoAsync(updateProductDto);

            var repository = _unitOfWork.GetRepository<BaseProduct, int>();
            var existingProduct = await repository.GetAll()
                .Include(p => p.PrintAreas)
                .Include(p => p.Templates)
                .Include(p => p.AvailableSizes)
                .Include(p => p.AvailableColors)
                .FirstOrDefaultAsync(p => p.Id == updateProductDto.Id);

            if (existingProduct == null)
            {
                throw new KeyNotFoundException($"Base product with ID {updateProductDto.Id} not found.");
            }

            // Validate category exists
            var categoryRepo = _unitOfWork.GetRepository<Category, int>();
            var categoryExists = await categoryRepo.GetAll()
                .AnyAsync(c => c.Id == updateProductDto.CategoryId && c.IsActive);
            if (!categoryExists)
            {
                throw new ArgumentException("Selected category does not exist or is inactive.");
            }

            // Validate sizes and colors
            await ValidateSizesAndColorsAsync(updateProductDto.AvailableSizeIds, updateProductDto.AvailableColorIds);

            // Map updates
            _mapper.Map(updateProductDto, existingProduct);
            existingProduct.LastModifiedBy = modifiedBy;
            existingProduct.LastModifiedOn = DateTime.UtcNow;

            repository.Update(existingProduct);

            // Update related entities
            await UpdatePrintAreasAsync(existingProduct, updateProductDto.PrintAreas);
            await UpdateTemplatesAsync(existingProduct, updateProductDto.Templates);
            await UpdateAvailableSizesAsync(existingProduct, updateProductDto.AvailableSizeIds);
            await UpdateAvailableColorsAsync(existingProduct, updateProductDto.AvailableColorIds);

            await _unitOfWork.CompleteAsync();

            return await GetBaseProductByIdAsync(existingProduct.Id)
                ?? throw new InvalidOperationException("Failed to retrieve updated product.");
        }

        public async Task<bool> DeleteBaseProductAsync(int id, string deletedBy)
        {
            var repository = _unitOfWork.GetRepository<BaseProduct, int>();
            var product = await repository.GetByIdAsync(id);
            if (product == null)
            {
                return false;
            }

            // Check if can deactivate (no active variants)
            if (await HasActiveVariantsAsync(id))
            {
                throw new InvalidOperationException("Cannot delete base product with active variants. Deactivate variants first.");
            }

            product.IsActive = false;
            product.LastModifiedBy = deletedBy;
            product.LastModifiedOn = DateTime.UtcNow;
            repository.Update(product);
 
            // Cascade soft-delete to related entities
            await SoftDeleteRelatedAsync(id);
            await _unitOfWork.CompleteAsync();

            return true;
        }

        public async Task<bool> ActivateBaseProductAsync(int id, string modifiedBy)
        {
            return await ToggleActiveStatusAsync(id, true, modifiedBy);
        }

        public async Task<bool> DeactivateBaseProductAsync(int id, string modifiedBy)
        {
            return await ToggleActiveStatusAsync(id, false, modifiedBy);
        }

        // IMPROVED VALIDATION METHODS

        private async Task ValidateCreateDtoAsync(CreateBaseProductDto dto)
        {
            // Check for unique name efficiently
            var repo = _unitOfWork.GetRepository<BaseProduct, int>();
            var nameExists = await repo.GetAll()
                .AnyAsync(p => p.Name.ToLower() == dto.Name.ToLower() && p.IsActive);

            if (nameExists)
            {
                throw new InvalidOperationException("Base product name must be unique.");
            }

            // Validate business rules
            ValidateBusinessRules(dto.PrintAreas, dto.Templates, dto.HasSizes, dto.AvailableSizeIds,
                                  dto.HasColors, dto.AvailableColorIds);

            // Ensure exactly one primary template
            var primaryTemplates = dto.Templates.Count(t => t.IsPrimary);
            if (primaryTemplates == 0)
            {
                // Default the first template to primary
                dto.Templates.First().IsPrimary = true;
            }
            else if (primaryTemplates > 1)
            {
                throw new InvalidOperationException("Only one template can be marked as primary.");
            }
        }


        private async Task ValidateUpdateDtoAsync(UpdateBaseProductDto dto)
        {
            // Check for unique name excluding current product
            var repo = _unitOfWork.GetRepository<BaseProduct, int>();
            var nameExists = await repo.GetAll()
                .AnyAsync(p => p.Name.ToLower() == dto.Name.ToLower() && p.Id != dto.Id && p.IsActive);

            if (nameExists)
            {
                throw new InvalidOperationException("Base product name must be unique.");
            }

            // Validate business rules
            ValidateBusinessRules(dto.PrintAreas.Cast<CreatePrintAreaDto>(),
                                  dto.Templates.Cast<CreateTemplateDto>(),
                                  dto.HasSizes, dto.AvailableSizeIds,
                                  dto.HasColors, dto.AvailableColorIds);

            // Ensure exactly one primary template
            var primaryTemplates = dto.Templates.Count(t => t.IsPrimary);
            if (primaryTemplates == 0)
            {
                // Default the first template to primary
                dto.Templates.First().IsPrimary = true;
            }
            else if (primaryTemplates > 1)
            {
                throw new InvalidOperationException("Only one template can be marked as primary.");
            }
        }


        private void ValidateBusinessRules(IEnumerable<CreatePrintAreaDto> printAreas,
                                         IEnumerable<CreateTemplateDto> templates,
                                         bool hasSizes, IList<int> availableSizeIds,
                                         bool hasColors, IList<int> availableColorIds)
        {
            if (!printAreas.Any())
            {
                throw new InvalidOperationException("At least one print area is required.");
            }

            if (!templates.Any())
            {
                throw new InvalidOperationException("At least one template is required.");
            }

            // Validate print area names are unique
            var areaNames = printAreas.Select(pa => pa.AreaName.ToLower()).ToList();
            if (areaNames.Count != areaNames.Distinct().Count())
            {
                throw new InvalidOperationException("Print area names must be unique.");
            }

            // Validate template view names are unique
            var viewNames = templates.Select(t => t.ViewName.ToLower()).ToList();
            if (viewNames.Count != viewNames.Distinct().Count())
            {
                throw new InvalidOperationException("Template view names must be unique.");
            }

            // Business rule: If product has sizes, must specify available sizes
            if (hasSizes && !availableSizeIds.Any())
            {
                throw new InvalidOperationException("Products with sizes must have at least one available size.");
            }

            // Business rule: If product has colors, must specify available colors
            if (hasColors && !availableColorIds.Any())
            {
                throw new InvalidOperationException("Products with colors must have at least one available color.");
            }
        }

        private async Task ValidateSizesAndColorsAsync(IList<int> sizeIds, IList<int> colorIds)
        {
            if (sizeIds.Any())
            {
                var sizeRepo = _unitOfWork.GetRepository<Size, int>();
                var validSizes = await sizeRepo.GetAll()
                    .Where(s => sizeIds.Contains(s.Id) && s.IsActive)
                    .CountAsync();

                if (validSizes != sizeIds.Count)
                {
                    throw new ArgumentException("One or more selected sizes do not exist or are inactive.");
                }
            }

            if (colorIds.Any())
            {
                var colorRepo = _unitOfWork.GetRepository<Color, int>();
                var validColors = await colorRepo.GetAll()
                    .Where(c => colorIds.Contains(c.Id) && c.IsActive)
                    .CountAsync();

                if (validColors != colorIds.Count)
                {
                    throw new ArgumentException("One or more selected colors do not exist or are inactive.");
                }
            }
        }

        // Helper methods with improved error handling and performance
        private async Task CreatePrintAreasAsync(BaseProduct product, List<CreatePrintAreaDto> printAreas)
        {
            var repo = _unitOfWork.GetRepository<BaseProductPrintArea, int>();
            var existing = await repo.GetAll()
                .Where(x => x.BaseProductId == product.Id && x.IsActive)
                .Select(x => x.AreaName.ToLower())
                .ToListAsync();

            var newAreas = printAreas
                .GroupBy(pa => pa.AreaName.ToLower())
                .Select(g => g.First())
                .Where(pa => !existing.Contains(pa.AreaName.ToLower()))
                .ToList();

            foreach (var pa in newAreas)
            {
                var printArea = _mapper.Map<BaseProductPrintArea>(pa);
                printArea.BaseProductId = product.Id;
                printArea.IsActive = true;
                await repo.AddAsync(printArea);
            }
        }


        private async Task CreateTemplatesAsync(BaseProduct product, List<CreateTemplateDto> templates)
        {
            var repo = _unitOfWork.GetRepository<BaseProductTemplate, int>();
            var existing = await repo.GetAll()
                .Where(x => x.BaseProductId == product.Id && x.IsActive)
                .Select(x => x.ViewName.ToLower())
                .ToListAsync();

            var newTemplates = templates
                .GroupBy(t => t.ViewName.ToLower())
                .Select(g => g.First())
                .Where(t => !existing.Contains(t.ViewName.ToLower()))
                .ToList();

            foreach (var t in newTemplates)
            {
                // Map to entity
                var template = _mapper.Map<BaseProductTemplate>(t);
                template.BaseProductId = product.Id;
                template.IsActive = true;

                // Get dimensions automatically if not provided
                if ((t.TemplateWidth == 0 || t.TemplateHeight == 0) && t.TemplateFile != null)
                {
                    var (w, h) = await _imageService.GetImageDimensionsAsync(t.TemplateFile);
                    template.TemplateWidth = w;
                    template.TemplateHeight = h;
                }

                await repo.AddAsync(template);
            }
        }



        private async Task CreateAvailableSizesAsync(BaseProduct product, List<int> sizeIds)
        {
            if (!sizeIds.Any()) return;

            var repo = _unitOfWork.GetRepository<BaseProductSize, int>();
            var existing = await repo.GetAll()
                .Where(x => x.BaseProductId == product.Id && x.IsActive)
                .Select(x => x.SizeId)
                .ToListAsync();

            var newSizes = sizeIds
                .Distinct()
                .Where(sizeId => !existing.Contains(sizeId))
                .Select(sizeId => new BaseProductSize
                {
                    BaseProductId = product.Id,
                    SizeId = sizeId,
                    IsActive = true,
                    PriceModifier = 0
                })
                .ToList();

            if (newSizes.Any())
                await repo.AddRangeAsync(newSizes);
        }


        private async Task CreateAvailableColorsAsync(BaseProduct product, List<int> colorIds)
        {
            if (!colorIds.Any()) return;

            var repo = _unitOfWork.GetRepository<BaseProductColor, int>();
            var existing = await repo.GetAll()
                .Where(x => x.BaseProductId == product.Id && x.IsActive)
                .Select(x => x.ColorId)
                .ToListAsync();

            var newColors = colorIds
                .Distinct()
                .Where(colorId => !existing.Contains(colorId))
                .Select(colorId => new BaseProductColor
                {
                    BaseProductId = product.Id,
                    ColorId = colorId,
                    IsActive = true,
                    PriceModifier = 0
                })
                .ToList();

            if (newColors.Any())
                await repo.AddRangeAsync(newColors);
        }


        private async Task UpdatePrintAreasAsync(BaseProduct product, List<UpdatePrintAreaDto> newPrintAreas)
        {
            var repository = _unitOfWork.GetRepository<BaseProductPrintArea, int>();

            // Get existing areas
            var existingAreas = product.PrintAreas.ToList();
            var newAreaIds = newPrintAreas.Where(pa => pa.Id > 0).Select(pa => pa.Id).ToHashSet();

            // Soft delete removed areas
            var areasToRemove = existingAreas.Where(pa => !newAreaIds.Contains(pa.Id)).ToList();
            foreach (var area in areasToRemove)
            {
                area.IsActive = false;
                repository.Update(area);
            }

            // Process new/updated areas
            foreach (var areaDto in newPrintAreas)
            {
                if (areaDto.Id == 0)
                {
                    // New area
                    var newArea = _mapper.Map<BaseProductPrintArea>(areaDto);
                    newArea.BaseProductId = product.Id;
                    newArea.IsActive = true;
                    await repository.AddAsync(newArea);
                }
                else
                {
                    // Update existing
                    var existingArea = existingAreas.FirstOrDefault(pa => pa.Id == areaDto.Id);
                    if (existingArea != null)
                    {
                        _mapper.Map(areaDto, existingArea);
                        existingArea.IsActive = true;
                        repository.Update(existingArea);
                    }
                }
            }
        }

        private async Task UpdateTemplatesAsync(BaseProduct product, List<UpdateTemplateDto> newTemplates)
        {
            var repository = _unitOfWork.GetRepository<BaseProductTemplate, int>();

            var existingTemplates = product.Templates.ToList();
            var newTemplateIds = newTemplates.Where(t => t.Id > 0).Select(t => t.Id).ToHashSet();

            // Soft delete removed templates
            var templatesToRemove = existingTemplates.Where(t => !newTemplateIds.Contains(t.Id)).ToList();
            foreach (var template in templatesToRemove)
            {
                template.IsActive = false;
                repository.Update(template);
            }

            foreach (var templateDto in newTemplates)
            {
                if (templateDto.Id == 0)
                {
                    var newTemplate = _mapper.Map<BaseProductTemplate>(templateDto);
                    newTemplate.BaseProductId = product.Id;
                    newTemplate.IsActive = true;
                    await repository.AddAsync(newTemplate);
                }
                else
                {
                    var existingTemplate = existingTemplates.FirstOrDefault(t => t.Id == templateDto.Id);
                    if (existingTemplate != null)
                    {
                        _mapper.Map(templateDto, existingTemplate);
                        existingTemplate.IsActive = true;
                        repository.Update(existingTemplate);
                    }
                }
            }
        }

        private async Task UpdateAvailableSizesAsync(BaseProduct product, List<int> sizeIds)
        {
            var repo = _unitOfWork.GetRepository<BaseProductSize, int>();
            var currentSizes = product.AvailableSizes.ToList();
            var currentSizeIds = currentSizes.Select(s => s.SizeId).ToHashSet();

            // Deactivate removed sizes
            var sizesToDeactivate = currentSizes.Where(s => !sizeIds.Contains(s.SizeId)).ToList();
            foreach (var size in sizesToDeactivate)
            {
                size.IsActive = false;
                repo.Update(size);
            }

            // Add/activate sizes
            foreach (var sizeId in sizeIds)
            {
                var existing = currentSizes.FirstOrDefault(s => s.SizeId == sizeId);
                if (existing != null)
                {
                    existing.IsActive = true;
                    repo.Update(existing);
                }
                else
                {
                    await repo.AddAsync(new BaseProductSize
                    {
                        BaseProductId = product.Id,
                        SizeId = sizeId,
                        IsActive = true,
                        PriceModifier = 0
                    });
                }
            }
        }

        private async Task UpdateAvailableColorsAsync(BaseProduct product, List<int> colorIds)
        {
            var repo = _unitOfWork.GetRepository<BaseProductColor, int>();
            var currentColors = product.AvailableColors.ToList();

            // Deactivate removed colors
            var colorsToDeactivate = currentColors.Where(c => !colorIds.Contains(c.ColorId)).ToList();
            foreach (var color in colorsToDeactivate)
            {
                color.IsActive = false;
                repo.Update(color);
            }

            // Add/activate colors
            foreach (var colorId in colorIds)
            {
                var existing = currentColors.FirstOrDefault(c => c.ColorId == colorId);
                if (existing != null)
                {
                    existing.IsActive = true;
                    repo.Update(existing);
                }
                else
                {
                    await repo.AddAsync(new BaseProductColor
                    {
                        BaseProductId = product.Id,
                        ColorId = colorId,
                        IsActive = true,
                        PriceModifier = 0
                    });
                }
            }
        }

        private async Task<bool> HasActiveVariantsAsync(int baseProductId)
        {
            var variantRepo = _unitOfWork.GetRepository<ProductVariant, int>();
            return await variantRepo.GetAll()
                .AnyAsync(v => v.BaseProductId == baseProductId && v.IsActive);
        }

        private async Task SoftDeleteRelatedAsync(int baseProductId)
        {
            // Soft-delete print areas
            var printRepo = _unitOfWork.GetRepository<BaseProductPrintArea, int>();
            var prints = await printRepo.GetAll()
                .Where(pa => pa.BaseProductId == baseProductId)
                .ToListAsync();
            foreach (var p in prints)
            {
                p.IsActive = false;
                printRepo.Update(p);
            }

            // Soft-delete templates
            var templateRepo = _unitOfWork.GetRepository<BaseProductTemplate, int>();
            var templates = await templateRepo.GetAll()
                .Where(t => t.BaseProductId == baseProductId)
                .ToListAsync();
            foreach (var t in templates)
            {
                t.IsActive = false;
                templateRepo.Update(t);
            }

            // Soft-delete sizes
            var sizeRepo = _unitOfWork.GetRepository<BaseProductSize, int>();
            var sizes = await sizeRepo.GetAll()
                .Where(s => s.BaseProductId == baseProductId)
                .ToListAsync();
            foreach (var s in sizes)
            {
                s.IsActive = false;
                sizeRepo.Update(s);
            }

            // Soft-delete colors
            var colorRepo = _unitOfWork.GetRepository<BaseProductColor, int>();
            var colors = await colorRepo.GetAll()
                .Where(c => c.BaseProductId == baseProductId)
                .ToListAsync();
            foreach (var c in colors)
            {
                c.IsActive = false;
                colorRepo.Update(c);
            }
        }

        private async Task<bool> ToggleActiveStatusAsync(int id, bool isActive, string modifiedBy)
        {
            var repo = _unitOfWork.GetRepository<BaseProduct, int>();
            var product = await repo.GetByIdAsync(id);
            if (product == null) return false;

            product.IsActive = isActive;
            product.LastModifiedBy = modifiedBy;
            product.LastModifiedOn = DateTime.UtcNow;
            repo.Update(product);

            // If deactivating, cascade to related entities
            if (!isActive)
            {
                await SoftDeleteRelatedAsync(id);
            }

            await _unitOfWork.CompleteAsync();
            return true;
        }
        // Add these methods to your ImprovedBaseProductService class

        public async Task<IEnumerable<BaseProductListDto>> GetBaseProductsByCategoryAsync(int categoryId)
        {
            var repository = _unitOfWork.GetRepository<BaseProduct, int>();
            var products = await repository.GetAll()
                .Include(p => p.Category)
                .Include(p => p.Templates.Where(t => t.IsActive && t.IsPrimary))
                .Include(p => p.ProductVariants.Where(v => v.IsActive))
                .Where(p => p.IsActive && p.CategoryId == categoryId)
                .OrderBy(p => p.Name)
                .ToListAsync();

            return _mapper.Map<IEnumerable<BaseProductListDto>>(products);
        }

        public async Task<IEnumerable<BaseProductListDto>> SearchBaseProductsAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return await GetAllBaseProductsAsync();
            }

            var repository = _unitOfWork.GetRepository<BaseProduct, int>();
            var lowerSearchTerm = searchTerm.ToLower();

            var products = await repository.GetAll()
                .Include(p => p.Category)
                .Include(p => p.Templates.Where(t => t.IsActive && t.IsPrimary))
                .Include(p => p.ProductVariants.Where(v => v.IsActive))
                .Where(p => p.IsActive &&
                       (p.Name.ToLower().Contains(lowerSearchTerm) ||
                        p.Description.ToLower().Contains(lowerSearchTerm) ||
                       p.Category.CategoryName.ToLower().Contains(lowerSearchTerm) ||
                        p.Category.CategoryName.ToLower().Contains(lowerSearchTerm)))
                .OrderBy(p => p.Name)
                .ToListAsync();

            return _mapper.Map<IEnumerable<BaseProductListDto>>(products);
        }

        public async Task<bool> CanDeleteBaseProductAsync(int id)
        {
            // Cannot delete if has active variants
            if (await HasActiveVariantsAsync(id))
            {
                return false;
            }

            // Add other business rules here
            // For example: Cannot delete if part of active promotions, etc.

            return true;
        }

        public async Task<IEnumerable<BaseProductListDto>> GetProductsCompatibleWithDesignAsync(int designId)
        {
            // This method would implement business logic to determine which base products
            // are compatible with a specific design based on print areas, size requirements, etc.

            var designRepo = _unitOfWork.GetRepository<Design, int>();
            var design = await designRepo.GetByIdAsync(designId);

            if (design == null)
            {
                throw new ArgumentException("Design not found", nameof(designId));
            }

            var repository = _unitOfWork.GetRepository<BaseProduct, int>();

            // Basic compatibility - all active products for now
            // You can add more sophisticated logic here based on your business rules
            var products = await repository.GetAll()
                .Include(p => p.Category)
                .Include(p => p.Templates.Where(t => t.IsActive && t.IsPrimary))
                .Include(p => p.ProductVariants.Where(v => v.IsActive))
                .Include(p => p.PrintAreas.Where(pa => pa.IsActive))
                .Where(p => p.IsActive)
                .OrderBy(p => p.Name)
                .ToListAsync();

            return _mapper.Map<IEnumerable<BaseProductListDto>>(products);
        }

        public async Task<bool> IsProductNameUniqueAsync(string name, int? excludeId = null)
        {
            var repo = _unitOfWork.GetRepository<BaseProduct, int>();
            var query = repo.GetAll().Where(p => p.Name.ToLower() == name.ToLower() && p.IsActive);

            if (excludeId.HasValue)
            {
                query = query.Where(p => p.Id != excludeId.Value);
            }

            return !await query.AnyAsync();
        }


        // Bulk operations
        public async Task<bool> BulkActivateAsync(List<int> ids, string modifiedBy)
        {
            var repo = _unitOfWork.GetRepository<BaseProduct, int>();
            var products = await repo.GetAll()
                .Where(p => ids.Contains(p.Id))
                .ToListAsync();

            foreach (var product in products)
            {
                product.IsActive = true;
                product.LastModifiedBy = modifiedBy;
                product.LastModifiedOn = DateTime.UtcNow;
                repo.Update(product);
            }

            await _unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<bool> BulkDeactivateAsync(List<int> ids, string modifiedBy)
        {
            var repo = _unitOfWork.GetRepository<BaseProduct, int>();
            var products = await repo.GetAll()
                .Where(p => ids.Contains(p.Id))
                .ToListAsync();

            foreach (var product in products)
            {
                // Check if can deactivate
                if (await HasActiveVariantsAsync(product.Id))
                {
                    throw new InvalidOperationException($"Cannot deactivate product '{product.Name}' - it has active variants.");
                }

                product.IsActive = false;
                product.LastModifiedBy = modifiedBy;
                product.LastModifiedOn = DateTime.UtcNow;
                repo.Update(product);

                // Cascade deactivation
                await SoftDeleteRelatedAsync(product.Id);
            }

            await _unitOfWork.CompleteAsync();
            return true;
        }
      
    }
}