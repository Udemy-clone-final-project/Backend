using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RedBubble.Application.DTOs.Design;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models.Identity;
using System.Security.Claims;

namespace RedBubble.Dashboard.Controllers
{
    [Authorize]
    public class DesignController : Controller
    {
        private readonly IDesignService _designService;
        private readonly IFileService _fileService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IServiceManager _serviceManager;

        public DesignController(
            IDesignService designService,
            IFileService fileService,
            UserManager<ApplicationUser> userManager,
            IServiceManager serviceManager)
        {
            _designService = designService;
            _fileService = fileService;
            _userManager = userManager;
            _serviceManager = serviceManager;
        }

        // GET: Design
        public async Task<IActionResult> Index(string searchItem, string sortColumn, string sortOrder, int page = 1, int pageSize = 10)
        {
            var designs = await _designService.GetAllAsync(searchItem, sortColumn, sortOrder, page, pageSize);
            ViewBag.SearchItem = searchItem;
            ViewBag.SortColumn = sortColumn;
            ViewBag.SortOrder = sortOrder;
            return View(designs);
        }

        // GET: Design/Details/5
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var design = await _designService.GetDesignByIdAsync(id);
                return View(design);
            }
            catch (KeyNotFoundException)
            {
                TempData["ErrorMessage"] = "Design not found.";
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Design/Create
        public async Task<IActionResult> Create()
        {
            var model = new CreateDesignDto { IsActive = true };
            model.AdminId = User.Claims.FirstOrDefault().Value;

            // Populate BaseProducts
            var baseProducts = await _serviceManager.baseProductService.GetAllBaseProductsAsync();
            ViewBag.BaseProducts = new MultiSelectList(baseProducts, "Id", "Name");

            return View(model);
        }


        // POST: Design/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateDesignDto model, IFormFile ImageFile)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                // Validate image file
                if (ImageFile == null || ImageFile.Length == 0)
                {
                    ModelState.AddModelError("ImageFile", "Please select an image file.");
                    return View(model);
                }

                if (!_fileService.IsValidImageFile(ImageFile))
                {
                    ModelState.AddModelError("ImageFile", "Please select a valid image file (JPG, PNG, GIF, WebP) under 5MB.");
                    return View(model);
                }

                // Upload image
                model.ImageUrl = await _fileService.UploadImageAsync(ImageFile, "designs");
                model.FileName = ImageFile.FileName;
                model.AdminId = _userManager.GetUserId(User);
                model.IsFileUpload = true;

                // Create design
                var createdDesign = await _designService.CreateAsync(model);

                TempData["SuccessMessage"] = "Design created successfully!";
                return RedirectToAction(nameof(Details), new { id = createdDesign.Id });
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Error creating design: " + ex.Message;
                return View(model);
            }
        }

        // GET: Design/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var design = await _designService.GetDesignByIdAsync(id);
                var updateModel = new UpdateDesignDto
                {
                    Id = design.Id,
                    Title = design.Title,
                    Description = design.Description,
                    Price = design.Price,
                    IsActive = design.IsActive,
                    ImageUrl = design.ImageUrl,
                    FileName = design.FileName,
                    AltText = design.AltText,
                    AdminId = design.AdminId
                };
                return View(updateModel);
            }
            catch (KeyNotFoundException)
            {
                TempData["ErrorMessage"] = "Design not found.";
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: Design/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateDesignDto model, IFormFile? ImageFile)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            // Remove ImageUrl from model validation since it might be updated
            ModelState.Remove("ImageUrl");

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                // Get the current design to preserve the old image URL
                var currentDesign = await _designService.GetDesignByIdAsync(id);
                string oldImageUrl = currentDesign.ImageUrl; // Preserve original URL

                // If new image is uploaded, process it
                if (ImageFile != null && ImageFile.Length > 0)
                {
                    if (!_fileService.IsValidImageFile(ImageFile))
                    {
                        ModelState.AddModelError("ImageFile", "Please select a valid image file (JPG, PNG, GIF, WebP) under 5MB.");
                        return View(model);
                    }

                    // Upload new image and update model
                    model.ImageUrl = await _fileService.UploadImageAsync(ImageFile, "designs");
                    model.FileName = ImageFile.FileName;
                    model.IsFileUpload = true;
                }
                else
                {
                    // Keep existing image if no new file uploaded
                    model.ImageUrl = currentDesign.ImageUrl;
                    model.FileName = currentDesign.FileName;
                }

                // Set admin ID
                model.AdminId = _userManager.GetUserId(User);

                // Update design
                await _designService.Update(model);

                // Clean up old image only if new one was uploaded successfully
                if (ImageFile != null && ImageFile.Length > 0 && !string.IsNullOrEmpty(oldImageUrl) && oldImageUrl != model.ImageUrl)
                {
                    _fileService.DeleteImage(oldImageUrl);
                }

                TempData["SuccessMessage"] = "Design updated successfully!";
                return RedirectToAction(nameof(Details), new { id = model.Id });
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Error updating design: " + ex.Message;
                // Ensure model has image data for re-display
                if (string.IsNullOrEmpty(model.ImageUrl))
                {
                    var currentDesign = await _designService.GetDesignByIdAsync(id);
                    model.ImageUrl = currentDesign.ImageUrl;
                    model.FileName = currentDesign.FileName;
                }
                return View(model);
            }
        }

        // POST: Design/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var design = await _designService.GetDesignByIdAsync(id);
                var result = await _designService.DeleteDesignAsync(id);

                if (result)
                {
                    _fileService.DeleteImage(design.ImageUrl);
                    TempData["SuccessMessage"] = "Design deleted successfully!";
                }
                else
                {
                    TempData["ErrorMessage"] = "Failed to delete design.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Error deleting design: " + ex.Message;
            }

            return RedirectToAction(nameof(Index));
        }
    }
}