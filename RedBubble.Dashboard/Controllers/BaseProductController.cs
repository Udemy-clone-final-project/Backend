using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Products;
using RedBubble.Application.Interfaces.Services;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;
using System.Text.Json;

namespace RedBubble.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BaseProductController : Controller
    {
        private readonly IBaseProductService _baseProductService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileService _fileService;
        private readonly IImageService _imageService;
        private readonly IServiceManager _serviceManager;

        public BaseProductController(
            IBaseProductService baseProductService,
            IUnitOfWork unitOfWork,
            IFileService fileService,
            IImageService imageService,
            IServiceManager serviceManager)
        {
            _baseProductService = baseProductService;
            _unitOfWork = unitOfWork;
            _fileService = fileService;
            _imageService = imageService;
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

        public async Task<IActionResult> Create()
        {
            await PopulateDropdownsAsync();
            return View(new CreateBaseProductDto());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateBaseProductDto createDto)
        {
            try
            {
                // FIXED: Log the received data for debugging
                var hasColorsValue = Request.Form["HasColors"];
                var hasSizesValue = Request.Form["HasSizes"];

                Console.WriteLine($"HasColors form value: '{hasColorsValue}'");
                Console.WriteLine($"HasSizes form value: '{hasSizesValue}'");
                Console.WriteLine($"DTO HasColors: {createDto.HasColors}");
                Console.WriteLine($"DTO HasSizes: {createDto.HasSizes}");

                // FIXED: Manual checkbox parsing if needed
                createDto.HasColors = Request.Form["HasColors"].Contains("true");
                createDto.HasSizes = Request.Form["HasSizes"].Contains("true");

                // Validate model state first
                if (!ModelState.IsValid)
                {
                    // FIXED: Log validation errors for debugging
                    foreach (var error in ModelState)
                    {
                        if (error.Value.Errors.Count > 0)
                        {
                            Console.WriteLine($"Validation error in {error.Key}: {string.Join(", ", error.Value.Errors.Select(e => e.ErrorMessage))}");
                        }
                    }

                    await PopulateDropdownsAsync();
                    return View(createDto);
                }

                // FIXED: Process template file uploads with better error handling
                if (createDto.Templates != null && createDto.Templates.Any())
                {
                    for (int i = 0; i < createDto.Templates.Count; i++)
                    {
                        var template = createDto.Templates[i];
                        try
                        {
                            await ProcessTemplateUploadsAsync(template);
                        }
                        catch (Exception ex)
                        {
                            ModelState.AddModelError($"Templates[{i}]", $"Template upload failed: {ex.Message}");
                            await PopulateDropdownsAsync();
                            return View(createDto);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("Templates", "At least one template is required.");
                    await PopulateDropdownsAsync();
                    return View(createDto);
                }

                // FIXED: Validate print areas against template dimensions with better error messages
                var validationResult = await ValidatePrintAreasAsync(createDto);
                if (!validationResult.IsValid)
                {
                    ModelState.AddModelError("PrintAreas", validationResult.ErrorMessage);
                    await PopulateDropdownsAsync();
                    return View(createDto);
                }

                // FIXED: Validate business rules before saving
                if (createDto.HasSizes && (createDto.AvailableSizeIds == null || !createDto.AvailableSizeIds.Any()))
                {
                    ModelState.AddModelError("AvailableSizeIds", "Please select at least one size when 'Has Sizes' is enabled.");
                    await PopulateDropdownsAsync();
                    return View(createDto);
                }

                if (createDto.HasColors && (createDto.AvailableColorIds == null || !createDto.AvailableColorIds.Any()))
                {
                    ModelState.AddModelError("AvailableColorIds", "Please select at least one color when 'Has Colors' is enabled.");
                    await PopulateDropdownsAsync();
                    return View(createDto);
                }

                var currentUser = User.Identity?.Name ?? "Admin";
                var result = await _baseProductService.CreateBaseProductAsync(createDto, currentUser);

                TempData["SuccessMessage"] = $"Base product '{result.Name}' created successfully.";
                return RedirectToAction(nameof(Details), new { id = result.Id });
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError("", ex.Message);
                await PopulateDropdownsAsync();
                return View(createDto);
            }
            catch (InvalidOperationException ex)
            {
                ModelState.AddModelError("", ex.Message);
                await PopulateDropdownsAsync();
                return View(createDto);
            }
            catch (Exception ex)
            {
                // FIXED: Better error logging
                Console.WriteLine($"Unexpected error creating base product: {ex}");
                ModelState.AddModelError("", "An unexpected error occurred while creating the product. Please check the logs and try again.");
                await PopulateDropdownsAsync();
                return View(createDto);
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await _baseProductService.GetBaseProductByIdAsync(id);
            if (product == null) return NotFound();

            var updateDto = MapToUpdateDto(product);
            await PopulateDropdownsAsync();
            return View(updateDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateBaseProductDto updateDto)
        {
            if (id != updateDto.Id) return BadRequest();

            // FIXED: Manual checkbox parsing for edit as well
            updateDto.HasColors = Request.Form["HasColors"].Contains("true");
            updateDto.HasSizes = Request.Form["HasSizes"].Contains("true");

            if (!ModelState.IsValid)
            {
                await PopulateDropdownsAsync();
                return View(updateDto);
            }

            try
            {
                // Process updated template file uploads
                if (updateDto.Templates != null)
                {
                    foreach (var template in updateDto.Templates)
                    {
                        await ProcessTemplateUploadsAsync(template);
                    }
                }

                var currentUser = User.Identity?.Name ?? "Admin";
                var result = await _baseProductService.UpdateBaseProductAsync(updateDto, currentUser);

                TempData["SuccessMessage"] = $"Base product '{result.Name}' updated successfully.";
                return RedirectToAction(nameof(Details), new { id = result.Id });
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError("", ex.Message);
                await PopulateDropdownsAsync();
                return View(updateDto);
            }
        }

        [HttpPost]
        public async Task<IActionResult> GetImageDimensions(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                    return BadRequest("No file provided");

                var (width, height) = await _imageService.GetImageDimensionsAsync(file);
                return Json(new { success = true, width, height });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> ValidatePrintArea([FromBody] PrintAreaValidationRequest request)
        {
            try
            {
                var isValid = _imageService.ValidatePrintAreaBounds(
                    request.TemplateWidth,
                    request.TemplateHeight,
                    request.PrintAreaX,
                    request.PrintAreaY,
                    request.PrintAreaWidth,
                    request.PrintAreaHeight);

                return Json(new
                {
                    success = true,
                    isValid,
                    message = isValid ? "Print area is within bounds" : "Print area exceeds template boundaries"
                });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, error = ex.Message });
            }
        }

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

        #region Helper Methods

        private async Task ProcessTemplateUploadsAsync<T>(T template) where T : CreateTemplateDto
        {
            if (template.TemplateFile != null && template.TemplateFile.Length > 0)
            {
                // FIXED: Validate file before upload
                if (!_fileService.IsValidImageFile(template.TemplateFile))
                {
                    throw new ArgumentException($"Template file '{template.TemplateFile.FileName}' is not a valid image file.");
                }

                // Upload file and extract dimensions
                template.TemplateUrl = await _fileService.UploadImageAsync(template.TemplateFile, "templates");
                var (width, height) = await _imageService.GetImageDimensionsAsync(template.TemplateFile);
                template.TemplateWidth = width;
                template.TemplateHeight = height;
            }

            if (template.MockupFile != null && template.MockupFile.Length > 0)
            {
                if (!_fileService.IsValidImageFile(template.MockupFile))
                {
                    throw new ArgumentException($"Mockup file '{template.MockupFile.FileName}' is not a valid image file.");
                }

                template.MockupUrl = await _fileService.UploadImageAsync(template.MockupFile, "mockups");
            }

            if (template.FlatMockupFile != null && template.FlatMockupFile.Length > 0)
            {
                if (!_fileService.IsValidImageFile(template.FlatMockupFile))
                {
                    throw new ArgumentException($"Flat mockup file '{template.FlatMockupFile.FileName}' is not a valid image file.");
                }

                template.FlatMockupUrl = await _fileService.UploadImageAsync(template.FlatMockupFile, "mockups");
            }
        }

        private async Task<ValidationResult> ValidatePrintAreasAsync(CreateBaseProductDto createDto)
        {
            if (createDto.Templates == null || createDto.PrintAreas == null)
            {
                return new ValidationResult { IsValid = true };
            }

            var errors = new List<string>();

            foreach (var printArea in createDto.PrintAreas)
            {
                // Find matching template for validation
                var matchingTemplate = createDto.Templates.FirstOrDefault(t =>
                    t.ViewName.Equals(printArea.AreaName, StringComparison.OrdinalIgnoreCase));

                if (matchingTemplate != null)
                {
                    var isValid = _imageService.ValidatePrintAreaBounds(
                        matchingTemplate.TemplateWidth,
                        matchingTemplate.TemplateHeight,
                        printArea.PositionX,
                        printArea.PositionY,
                        (int)printArea.Width,
                        (int)printArea.Height);

                    if (!isValid)
                    {
                        errors.Add($"Print area '{printArea.AreaName}' exceeds template '{matchingTemplate.ViewName}' boundaries " +
                                  $"(Template: {matchingTemplate.TemplateWidth}x{matchingTemplate.TemplateHeight}px, " +
                                  $"Print Area: {printArea.PositionX},{printArea.PositionY} {printArea.Width}x{printArea.Height}px)");
                    }
                }
                else
                {
                    errors.Add($"Print area '{printArea.AreaName}' references template view that doesn't exist.");
                }
            }

            return new ValidationResult
            {
                IsValid = !errors.Any(),
                ErrorMessage = string.Join("; ", errors)
            };
        }

        private async Task PopulateDropdownsAsync()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error populating dropdowns: {ex}");
                ViewBag.SubCategories = new SelectList(Enumerable.Empty<Category>(), "Id", "CategoryName");
                ViewBag.AllSizes = Enumerable.Empty<RedBubble.Application.DTOs.SizeDto>();
                ViewBag.AllColors = Enumerable.Empty<RedBubble.Application.DTOs.ColorDto>();
                throw; // Re-throw to let the controller handle the error
            }
        }

        private UpdateBaseProductDto MapToUpdateDto(BaseProductDto product)
        {
            return new UpdateBaseProductDto
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
                AvailableSizeIds = product.AvailableSizes.Where(s => s.IsActive).Select(s => s.SizeId).ToList(),
                AvailableColorIds = product.AvailableColors.Where(c => c.IsActive).Select(c => c.ColorId).ToList()
            };
        }

        #endregion

        #region Helper Classes

        public class ValidationResult
        {
            public bool IsValid { get; set; }
            public string ErrorMessage { get; set; } = string.Empty;
        }

        #endregion
    }

    public class PrintAreaValidationRequest
    {
        public int TemplateWidth { get; set; }
        public int TemplateHeight { get; set; }
        public int PrintAreaX { get; set; }
        public int PrintAreaY { get; set; }
        public int PrintAreaWidth { get; set; }
        public int PrintAreaHeight { get; set; }
    }
}