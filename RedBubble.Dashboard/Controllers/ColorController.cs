using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.DTOs;
using RedBubble.Application.Interfaces;

namespace RedBubble.Dashboard.Controllers
{
    [AllowAnonymous]
    public class ColorController : Controller
    {
        private readonly IServiceManager serviceManager;
        public ColorController(IServiceManager _serviceManager)
        {
            serviceManager = _serviceManager;
        }

        // GET: Color
        public async Task<IActionResult> Index()
        {
            try
            {
                var colors = await serviceManager.colorService.GetAllAsync();
                return View(colors);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error loading colors: {ex.Message}";
                return View(new List<ColorDto>());
            }
        }

        //// GET: Color/Details/5
        //public async Task<IActionResult> Details(int id)
        //{
        //    try
        //    {
        //        var color = await _colorService.GetByIdAsync(id);
        //        return View(color);
        //    }
        //    catch (KeyNotFoundException)
        //    {
        //        TempData["ErrorMessage"] = "Color not found.";
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch (Exception ex)
        //    {
        //        TempData["ErrorMessage"] = $"Error loading color: {ex.Message}";
        //        return RedirectToAction(nameof(Index));
        //    }
        //}

        // GET: Color/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Color/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateColorDto createColorDto)
        {
            if (!ModelState.IsValid)
            {
                return View(createColorDto);
            }

            try
            {
                var colorId = await serviceManager.colorService.CreateAsync(createColorDto);
                TempData["SuccessMessage"] = "Color created successfully!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error creating color: {ex.Message}";
                return View(createColorDto);
            }
        }

        // GET: Color/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var color = await serviceManager.colorService.GetByIdAsync(id);
                var updateColorDto = new UpdateColorDto
                {
                    Id = color.Id,
                    ColorName = color.ColorName,
                    ColorCode = color.ColorCode,
                    IsActive = color.IsActive
                };
                return View(updateColorDto);
            }
            catch (KeyNotFoundException)
            {
                TempData["ErrorMessage"] = "Color not found.";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error loading color: {ex.Message}";
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: Color/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateColorDto updateColorDto)
        {
            if (id != updateColorDto.Id)
            {
                TempData["ErrorMessage"] = "Invalid color ID.";
                return RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid)
            {
                return View(updateColorDto);
            }

            try
            {
                var result = await serviceManager.colorService.UpdateAsync(updateColorDto);
                if (result)
                {
                    TempData["SuccessMessage"] = "Color updated successfully!";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["ErrorMessage"] = "Color not found.";
                    return View(updateColorDto);
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error updating color: {ex.Message}";
                return View(updateColorDto);
            }
        }

        // POST: Color/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await serviceManager.colorService.DeleteAsync(id);
                if (result)
                {
                    TempData["SuccessMessage"] = "Color deleted successfully!";
                }
                else
                {
                    TempData["ErrorMessage"] = "Color not found.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error deleting color: {ex.Message}";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}