using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.Services.Interfaces;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;
using System.Security.Claims;

namespace RedBubble.Application.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Category, int> _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = _unitOfWork.GetRepository<Category, int>();
            _mapper = mapper;
        }

        public async Task<CategoryDto?> GetByIdAsync(int id)
        {
            var category = await _categoryRepository.GetAll()
                .Include(c => c.ParentCategory)
                .FirstOrDefaultAsync(c => c.Id == id);

            return category == null ? null : _mapper.Map<CategoryDto>(category);
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAll()
                .Include(c => c.ParentCategory)
                .ToListAsync();

            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }
        public async Task<CategoryDto> CreateAsync(CreateCategoryDto createDto)
        {
            if (createDto.ParentCategoryId.HasValue && createDto.ParentCategoryId.Value != 0)
            {
                var parentExists = await _categoryRepository.GetByIdAsync(createDto.ParentCategoryId.Value);
                if (parentExists == null)
                {
                    throw new ArgumentException("The selected parent category does not exist.");
                }
            }

            var category = _mapper.Map<Category>(createDto);
            category.CreatedOn = DateTime.UtcNow;
            
            category.CreatedBy = "System";
            category.LastModifiedBy = "System"; 

            await _categoryRepository.AddAsync(category);
            try
            {
                await _unitOfWork.CompleteAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("Database error occurred while saving the category.", ex);
            }

            var createdCategory = await GetByIdAsync(category.Id);
            if (createdCategory == null)
            {
                throw new InvalidOperationException("Failed to retrieve the created category.");
            }
            return createdCategory;
        }

        public async Task<CategoryDto> UpdateAsync(UpdateCategoryDto updateDto)
        {
            var existingCategory = await _categoryRepository.GetByIdAsync(updateDto.Id);
            if (existingCategory == null)
            {
                throw new ArgumentException("Category not found.");
            }

            if (updateDto.ParentCategoryId.HasValue)
            {
                var parentExists = await _categoryRepository.GetByIdAsync(updateDto.ParentCategoryId.Value);
                if (parentExists == null)
                {
                    throw new ArgumentException("Parent category does not exist.");
                }

                if (updateDto.ParentCategoryId.Value == updateDto.Id)
                {
                    throw new ArgumentException("Category cannot be its own parent.");
                }
            }

            _mapper.Map(updateDto, existingCategory);

            _categoryRepository.Update(existingCategory);
            await _unitOfWork.CompleteAsync();

            return await GetByIdAsync(existingCategory.Id)
                ?? throw new InvalidOperationException("Failed to retrieve updated category.");
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
            {
                return false;
            }

            if (!await CanDeleteCategoryAsync(id))
            {
                throw new InvalidOperationException("Cannot delete category that has subcategories or products.");
            }

            _categoryRepository.Delete(category);
            await _unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<IEnumerable<CategoryDto>> GetMainCategoriesAsync()
        {
            var mainCategories = await _categoryRepository.GetAll()
                .Where(c => c.ParentCategoryId == null)
                .Include(c => c.ParentCategory)
                .ToListAsync();

            return _mapper.Map<IEnumerable<CategoryDto>>(mainCategories);
        }

        public async Task<IEnumerable<CategoryDto>> GetSubCategoriesAsync(int parentCategoryId)
        {
            var subCategories = await _categoryRepository.GetAll()
                .Where(c => c.ParentCategoryId == parentCategoryId)
                .Include(c => c.ParentCategory)
                .ToListAsync();

            return _mapper.Map<IEnumerable<CategoryDto>>(subCategories);
        }

        public async Task<CategoryWithSubCategoriesDto?> GetCategoryWithSubCategoriesAsync(int categoryId)
        {
            var category = await _categoryRepository.GetAll()
                .Include(c => c.SubCategories)
                .FirstOrDefaultAsync(c => c.Id == categoryId);

            if (category == null) return null;

            var dto = _mapper.Map<CategoryWithSubCategoriesDto>(category);
            dto.SubCategoriesCount = category.SubCategories.Count;

            return dto;
        }

        public async Task<IEnumerable<CategoryWithSubCategoriesDto>> GetAllCategoriesWithSubCategoriesAsync()
        {
            var categories = await _categoryRepository.GetAll()
                .Where(c => c.ParentCategoryId == null)
                .Include(c => c.SubCategories)
                .ToListAsync();

            var dtos = _mapper.Map<List<CategoryWithSubCategoriesDto>>(categories);
            foreach (var dto in dtos)
            {
                dto.SubCategoriesCount = dto.SubCategories?.Count ?? 0;
            }

            return dtos;
        }

        public async Task<bool> CanDeleteCategoryAsync(int categoryId)
        {
            var category = await _categoryRepository.GetAll()
                .Include(c => c.SubCategories)
                .Include(c => c.BaseProducts)
                .FirstOrDefaultAsync(c => c.Id == categoryId);

            return category != null && !category.SubCategories.Any() && !category.BaseProducts.Any();
        }
    }
}