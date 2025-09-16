using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Services;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;

namespace RedBubble.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BaseProductController : Controller
    {
        private readonly IBaseProductService _baseProductService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _fileService;
        private readonly IServiceManager _serviceManager;

        public BaseProductController(
            IBaseProductService baseProductService,
            IUnitOfWork unitOfWork,
            IFileService fileService,
            IServiceManager serviceManager)
        {
            _baseProductService = baseProductService;
            _unitOfWork = unitOfWork;
            _fileService = fileService;
            _serviceManager = serviceManager;
        }

       
        public async Task<IActionResult> Index(string? search, bool? hasSize, bool? hasColors)
        {
            var products = await _baseProductService.GetAllBaseProductsAsync();

            if (!string.IsNullOrWhiteSpace(search))
            {
                products = products.Where(p =>
                    p.Name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    p.CategoryName?.Contains(search, StringComparison.OrdinalIgnoreCase) == true);
            }

            if (hasSize.HasValue)
            {
                products = products.Where(p => p.HasSizes == hasSize.Value);
            }

            if (hasColors.HasValue)
            {
                products = products.Where(p => p.HasColors == hasColors.Value);
            }

            ViewData["CurrentFilter"] = search;
            ViewData["CurrentHasSize"] = hasSize;
            ViewData["CurrentHasColors"] = hasColors;

            return View(products);
        }


        // GET: BaseProduct/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var product = await _baseProductService.GetBaseProductByIdAsync(id);
            if (product == null) return NotFound();

            var variantRepository = _unitOfWork.GetRepository<ProductVariant, int>();
            var variants = await variantRepository.GetAllAsync();
            var productVariants = variants.Where(v => v.BaseProductId == id && v.IsActive);

            ViewBag.ProductVariants = productVariants;
            return View(product);
        }

        // GET: BaseProduct/Create
        public async Task<IActionResult> Create()
        {
            await PopulateDropdownsAsync();

            return View(new CreateBaseProductDto());
        }

        // POST: BaseProduct/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateBaseProductDto createDto,
            List<IFormFile>? templateFiles, List<IFormFile>? mockupFiles)
        {
            if (!ModelState.IsValid)
             {
                await PopulateDropdownsAsync();
                return View(createDto);
            }

            if (templateFiles != null && templateFiles.Any())
            {
                await HandleTemplateUploadsAsync(createDto, templateFiles, mockupFiles);
            }

            var currentUser = User.Identity?.Name ?? "Admin";
            var result = await _baseProductService.CreateBaseProductAsync(createDto, currentUser);

            TempData["SuccessMessage"] = $"Base product '{result.Name}' created successfully.";
            return RedirectToAction(nameof(Details), new { id = result.Id });
        }

        // GET: BaseProduct/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _baseProductService.GetBaseProductByIdAsync(id);
            if (product == null) return NotFound();

            var updateDto = new UpdateBaseProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                BasePrice = product.BasePrice,
                CategoryId = product.CategoryId,
                HasSizes = product.HasSizes,
                HasColors = product.HasColors,
                IsActive = product.IsActive,
                PrintAreas = product.PrintAreas.Select(pa => new UpdatePrintAreaDto
                {
                    Id = pa.Id,
                    AreaName = pa.AreaName,
                    Width = pa.Width,
                    Height = pa.Height,
                    PositionX = pa.PositionX,
                    PositionY = pa.PositionY,
                    MinDPI = pa.MinDPI,
                    DisplayOrder = pa.DisplayOrder,
                    IsActive = pa.IsActive
                }).ToList(),
                Templates = product.Templates.Select(t => new UpdateTemplateDto
                {
                    Id = t.Id,
                    ViewName = t.ViewName,
                    TemplateUrl = t.TemplateUrl,
                    MockupUrl = t.MockupUrl,
                    FlatMockupUrl = t.FlatMockupUrl,
                    TemplateWidth = t.TemplateWidth,
                    TemplateHeight = t.TemplateHeight,
                    IsPrimary = t.IsPrimary,
                    DisplayOrder = t.DisplayOrder,
                    IsActive = t.IsActive
                }).ToList(),
                AvailableSizeIds = product.AvailableSizes.Select(s => s.SizeId).ToList(),
                AvailableColorIds = product.AvailableColors.Select(c => c.ColorId).ToList()
            };

            await PopulateDropdownsAsync();
            return View(updateDto);
        }

        // POST: BaseProduct/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateBaseProductDto updateDto,
            List<IFormFile>? templateFiles, List<IFormFile>? mockupFiles)
        {
            if (id != updateDto.Id) return BadRequest();
            if (!ModelState.IsValid)
            {
                await PopulateDropdownsAsync();
                return View(updateDto);
            }

            if (templateFiles != null && templateFiles.Any())
            {
                await HandleTemplateUploadsAsync(updateDto, templateFiles, mockupFiles);
            }

            var currentUser = User.Identity?.Name ?? "Admin";
            var result = await _baseProductService.UpdateBaseProductAsync(updateDto, currentUser);

            TempData["SuccessMessage"] = $"Base product '{result.Name}' updated successfully.";
            return RedirectToAction(nameof(Details), new { id = result.Id });
        }

        // GET: BaseProduct/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _baseProductService.GetBaseProductByIdAsync(id);
            if (product == null) return NotFound();

            var variantRepository = _unitOfWork.GetRepository<ProductVariant, int>();
            var variants = await variantRepository.GetAllAsync();
            var hasActiveVariants = variants.Any(v => v.BaseProductId == id && v.IsActive);

            ViewBag.CanDelete = !hasActiveVariants;
            ViewBag.DeleteMessage = hasActiveVariants
                ? "This base product cannot be deleted because it has active variants. Please deactivate them first."
                : "Are you sure you want to delete this base product?";

            return View(product);
        }

        // POST: BaseProduct/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var success = await _baseProductService.DeleteBaseProductAsync(id, "system");

            TempData["SuccessMessage"] = success
                ? "Base product deleted successfully."
                : "Base product not found.";

            return RedirectToAction(nameof(Index));
        }

        // GET: BaseProduct/Variants/5
        public async Task<IActionResult> Variants(int id)
        {
            var product = await _baseProductService.GetBaseProductByIdAsync(id);
            if (product == null) return NotFound();

            var variantRepository = _unitOfWork.GetRepository<ProductVariant, int>();
            var variants = await variantRepository.GetAllAsync();
            var productVariants = variants.Where(v => v.BaseProductId == id && v.IsActive).ToList();

            ViewBag.BaseProductName = product.Name;
            ViewBag.BaseProductId = id;

            return View(productVariants);
        }

        #region Helpers

        private async Task PopulateDropdownsAsync()
        {
            var categoryRepository = _unitOfWork.GetRepository<Category, int>();
            var categories = await categoryRepository.GetAllAsync();
            var subCategories = categories
                .Where(c => c.IsActive && c.ParentCategoryId != null)
                .OrderBy(c => c.CategoryName);

            ViewBag.SubCategories = new SelectList(subCategories, "Id", "CategoryName");

            ViewBag.AllSizes = await _serviceManager.sizeService.GetAllSizesAsync();
            ViewBag.AllColors = await _serviceManager.colorService.GetAllAsync();
        }



        private async Task HandleTemplateUploadsAsync<T>(T dto, List<IFormFile> templateFiles, List<IFormFile>? mockupFiles)
            where T : class
        {
            var templates = GetPropertyValue<List<CreateTemplateDto>>(dto, "Templates") ?? new();
            var updateTemplates = GetPropertyValue<List<UpdateTemplateDto>>(dto, "Templates");

            for (int i = 0; i < templateFiles.Count && i < templates.Count; i++)
            {
                var templateUrl = await _fileService.UploadImageAsync(templateFiles[i], "templates");
                if (templates.Any()) templates[i].TemplateUrl = templateUrl;
                else if (updateTemplates != null && updateTemplates.Any()) updateTemplates[i].TemplateUrl = templateUrl;

                if (mockupFiles != null && i < mockupFiles.Count)
                {
                    var mockupUrl = await _fileService.UploadImageAsync(mockupFiles[i], "mockups");
                    if (templates.Any()) templates[i].MockupUrl = mockupUrl;
                    else if (updateTemplates != null) updateTemplates[i].MockupUrl = mockupUrl;
                }
            }
        }

        private static TValue GetPropertyValue<TValue>(object obj, string propertyName)
        {
            var property = obj.GetType().GetProperty(propertyName);
            return property != null ? (TValue)property.GetValue(obj) : default!;
        }
        #endregion
    }
}
