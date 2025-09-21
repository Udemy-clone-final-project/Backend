using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.DTOs;
using RedBubble.Application.Interfaces;

namespace RedBubble.Dashboard.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SizeController : Controller
    {
        private readonly IServiceManager serviceManager;

        public SizeController(IServiceManager _serviceManager)
        {
            serviceManager = _serviceManager;
        }

        // GET: Size
        public async Task<IActionResult> Index()
        {
            var sizes = await serviceManager.sizeService.GetAllSizesAsync();
            return View(sizes);
        }

        //// GET: Size/Details/5
        //public async Task<IActionResult> Details(int id)
        //{
        //    var size = await _sizeService.GetSizeByIdAsync(id);
        //    if (size == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(size);
        //}

        // GET: Size/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Size/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateSizeDto createSizeDto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await serviceManager.sizeService.CreateSizeAsync(createSizeDto);
                    TempData["SuccessMessage"] = "Size created successfully.";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["ErrorMessage"] = $"Error creating size: {ex.Message}";
                }
            }

            return View(createSizeDto);
        }

        // GET: Size/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var size = await serviceManager.sizeService.GetSizeByIdAsync(id);
            if (size == null)
            {
                return NotFound();
            }

            var updateSizeDto = new UpdateSizeDto
            {
                Id = size.Id,
                SizeName = size.SizeName,
                Description = size.Description,
                IsActive = size.IsActive
            };

            return View(updateSizeDto);
        }

        // POST: Size/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateSizeDto updateSizeDto)
        {
            if (id != updateSizeDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await serviceManager.sizeService.UpdateSizeAsync(updateSizeDto);
                    TempData["SuccessMessage"] = "Size updated successfully.";
                    return RedirectToAction(nameof(Index));
                }
                catch (KeyNotFoundException)
                {
                    return NotFound();
                }
                catch (Exception ex)
                {
                    TempData["ErrorMessage"] = $"Error updating size: {ex.Message}";
                }
            }

            return View(updateSizeDto);
        }

        // POST: Size/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await serviceManager.sizeService.DeleteSizeAsync(id);
                TempData["SuccessMessage"] = "Size deleted successfully.";
            }
            catch (KeyNotFoundException)
            {
                TempData["ErrorMessage"] = "Size not found.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error deleting size: {ex.Message}";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}