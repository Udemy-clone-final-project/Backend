using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Services.Interfaces;

namespace RedBubble.Dashboard.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
       
        private readonly IServiceManager serviceManager;
        public CategoryController(IServiceManager _serviceManager)
        {
            serviceManager = _serviceManager;
        }

        // GET: Category
        public async Task<IActionResult> Index(string search)
        {
            var categories = await serviceManager.categoryService.GetAllCategoriesWithSubCategoriesAsync();
            if (!string.IsNullOrEmpty(search))
            {
                categories = categories.Where(c => c.CategoryName.Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            ViewData["CurrentFilter"] = search;
            return View(categories);
        }

        // GET: Category/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var category = await serviceManager.categoryService.GetCategoryWithSubCategoriesAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // GET: Category/Create
        public async Task<IActionResult> Create()
        {
            await PopulateParentCategoriesDropdown();
            return View(new CreateCategoryDto());
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCategoryDto createDto)
        {
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine($"Validation Error: {error.ErrorMessage}");
                }
                await PopulateParentCategoriesDropdown(createDto.ParentCategoryId);
                return View(createDto);
            }

            try
            {
                await serviceManager.categoryService.CreateAsync(createDto);
                TempData["Success"] = "Category created successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception: {ex.Message}");
                TempData["Error"] = ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception: {ex.Message} - StackTrace: {ex.StackTrace}");
                TempData["Error"] = "An error occurred while creating the category. Please check the logs for details.";
            }

            await PopulateParentCategoriesDropdown(createDto.ParentCategoryId);
            return View(createDto);
        }

        // GET: Category/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var category = await serviceManager.categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            var updateDto = new UpdateCategoryDto
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                Description = category.Description,
                ParentCategoryId = category.ParentCategoryId
            };

            await PopulateParentCategoriesDropdown(category.ParentCategoryId, category.Id);
            return View(updateDto);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateCategoryDto updateDto)
        {
            if (id != updateDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await serviceManager.categoryService.UpdateAsync(updateDto);
                    TempData["Success"] = "Category updated successfully!";
                    return RedirectToAction(nameof(Index));
                }
                catch (ArgumentException ex)
                {
                    TempData["Error"] = ex.Message;
                }
                catch (Exception)
                {
                    TempData["Error"] = "An error occurred while updating the category.";
                }
            }

            await PopulateParentCategoriesDropdown(updateDto.ParentCategoryId, updateDto.Id);
            return View(updateDto);
        }

        // GET: Category/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var category = await serviceManager.categoryService.GetCategoryWithSubCategoriesAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            var canDelete = await serviceManager.categoryService.CanDeleteCategoryAsync(id);
            ViewBag.CanDelete = canDelete;
            ViewBag.DeleteMessage = canDelete
                ? "Are you sure you want to delete this category?"
                : "This category cannot be deleted because it has subcategories or products associated with it.";

            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var result = await serviceManager.categoryService.DeleteAsync(id);
                if (result)
                {
                    TempData["Success"] = "Category deleted successfully!";
                }
                else
                {
                    TempData["Error"] = "Category not found.";
                }
            }
            catch (InvalidOperationException ex)
            {
                TempData["Error"] = ex.Message;
            }
            catch (Exception)
            {
                TempData["Error"] = "An error occurred while deleting the category.";
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Category/SubCategories/5
        public async Task<IActionResult> SubCategories(int id)
        {
            var category = await serviceManager.categoryService.GetCategoryWithSubCategoriesAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            ViewBag.ParentCategoryId = id;
            ViewBag.ParentCategoryName = category.CategoryName;
            return View(category.SubCategories);
        }

        // AJAX endpoint to get subcategories
        public async Task<IActionResult> GetSubCategories(int parentId)
        {
            var subCategories = await serviceManager.categoryService.GetSubCategoriesAsync(parentId);
            return Json(subCategories);
        }

        private async Task PopulateParentCategoriesDropdown(int? selectedParentId = null, int? excludeId = null)
        {
            var mainCategories = await serviceManager.categoryService.GetMainCategoriesAsync();

            if (excludeId.HasValue)
            {
                mainCategories = mainCategories.Where(c => c.Id != excludeId.Value);
            }

            var selectList = mainCategories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.CategoryName,
                Selected = c.Id == selectedParentId
            }).ToList();

            selectList.Insert(0, new SelectListItem
            {
                Value = "",
                Text = "-- Select Parent Category (Optional) --",
                Selected = !selectedParentId.HasValue
            });

            ViewBag.ParentCategories = selectList;
        }
    }
}