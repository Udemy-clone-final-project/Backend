using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.DTOs.Products.ProductVariant;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RedBubble.Dashboard.Controllers
{
    //[Authorize(Roles = "Admin")]
    [AllowAnonymous]
    public class BaseProductController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public BaseProductController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        // GET: BaseProduct
        public async Task<IActionResult> Index(string search)
        {
            var products = await _serviceManager.baseProductService.GetAllBaseProductsAsync();
            var filteredProducts = products.AsQueryable();

            // Apply search
            if (!string.IsNullOrEmpty(search))
            {
                filteredProducts = filteredProducts.Where(p => p.Name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                                                              p.Description.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                                                              p.CategoryName.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            var productList = filteredProducts.Select(p => new ProductListDto
            {
                Id = p.Id,
                Name = p.Name,
                BasePrice = p.BasePrice,
                CategoryName = p.CategoryName
            }).ToList();

            ViewData["CurrentFilter"] = search;
            return View(productList);
        }

        // GET: BaseProduct/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var product = await _serviceManager.baseProductService.GetBaseProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            // Fetch ProductVariants for this BaseProduct
            var variants = await _serviceManager.productVariantService.GetAllProductVariantsAsync(
                searchItem: null, sortColumn: null, sortOrder: null, categoryId: null, page: 1, pageSize: int.MaxValue);
            ViewBag.ProductVariants = variants.Items.Where(v => v.BaseProductId == id).ToList();

            return View(product);
        }

        // GET: BaseProduct/Create
        public async Task<IActionResult> Create()
        {
            await PopulateCategoriesDropdown();
            return View(new CreateProductDto());
        }

        // POST: BaseProduct/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProductDto createDto)
        {
            if (!ModelState.IsValid)
            {
                await PopulateCategoriesDropdown(createDto.CategoryId);
                return View(createDto);
            }

            try
            {
                var userId = User.Identity?.Name ?? "System";
                await _serviceManager.baseProductService.CreateBaseProductAsync(createDto, userId);
                TempData["SuccessMessage"] = "Base Product created successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "An error occurred while creating the base product.";
            }

            await PopulateCategoriesDropdown(createDto.CategoryId);
            return View(createDto);
        }

        // GET: BaseProduct/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _serviceManager.baseProductService.GetBaseProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var updateDto = new UpdateProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                BasePrice = product.BasePrice,
                CategoryId = product.CategoryId
            };

            await PopulateCategoriesDropdown(product.CategoryId);
            return View(updateDto);
        }

        // POST: BaseProduct/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateProductDto updateDto)
        {
            if (id != updateDto.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                await PopulateCategoriesDropdown(updateDto.CategoryId);
                return View(updateDto);
            }

            try
            {
                var userId = User.Identity?.Name ?? "System";
                var result = await _serviceManager.baseProductService.UpdateBaseProductAsync(updateDto, userId);
                if (result == null)
                {
                    return NotFound();
                }
                TempData["SuccessMessage"] = "Base Product updated successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "An error occurred while updating the base product.";
            }

            await PopulateCategoriesDropdown(updateDto.CategoryId);
            return View(updateDto);
        }

        // GET: BaseProduct/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _serviceManager.baseProductService.GetBaseProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            // Check if the product has associated variants
            var variants = await _serviceManager.productVariantService.GetAllProductVariantsAsync(
                searchItem: null, sortColumn: null, sortOrder: null, categoryId: null, page: 1, pageSize: int.MaxValue);
            var hasVariants = variants.Items.Any(v => v.BaseProductId == id);
            ViewBag.CanDelete = !hasVariants;
            ViewBag.DeleteMessage = hasVariants
                ? "This base product cannot be deleted because it has associated product variants."
                : "Are you sure you want to delete this base product?";

            return View(product);
        }

        // POST: BaseProduct/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var result = await _serviceManager.baseProductService.DeleteBaseProductAsync(id);
                if (result)
                {
                    TempData["SuccessMessage"] = "Base Product deleted successfully!";
                }
                else
                {
                    TempData["ErrorMessage"] = "Base Product not found.";
                }
            }
            catch (Exception)
            {
                TempData["ErrorMessage"] = "An error occurred while deleting the base product.";
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: BaseProduct/Variants/5
        public async Task<IActionResult> Variants(int id)
        {
            var product = await _serviceManager.baseProductService.GetBaseProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var variants = await _serviceManager.productVariantService.GetAllProductVariantsAsync(
                searchItem: null, sortColumn: null, sortOrder: null, categoryId: null, page: 1, pageSize: int.MaxValue);
            var productVariants = variants.Items.Where(v => v.BaseProductId == id).ToList();

            ViewBag.BaseProductName = product.Name;
            ViewBag.BaseProductId = id;
            return View(productVariants);
        }

        private async Task PopulateCategoriesDropdown(int? selectedCategoryId = null)
        {
            var categories = await _serviceManager.categoryService.GetAllCategoriesWithSubCategoriesAsync();
            var selectList = categories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.CategoryName,
                Selected = c.Id == selectedCategoryId
            }).ToList();

            selectList.Insert(0, new SelectListItem
            {
                Value = "",
                Text = "-- Select Category --",
                Selected = !selectedCategoryId.HasValue
            });

            ViewBag.Categories = selectList;
        }
    }
}