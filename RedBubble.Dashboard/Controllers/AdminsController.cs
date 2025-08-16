using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Dashboard.Models;

using RedBubble.Domain.Entities.Models.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedBubble.Dashboard.Controllers
{
    // [Authorize(Roles = "Admin")]
    public class AdminsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminsController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            // Get only users in the "Admin" role
            var admins = await _userManager.GetUsersInRoleAsync("Admin");

            var adminViewModels = new List<UserViewModel>();
            foreach (var admin in admins)
            {
                adminViewModels.Add(new UserViewModel
                {
                    Id = admin.Id,
                    UserName = admin.UserName,
                    DisplayName = admin.DisplayName,
                    Email = admin.Email,
                    IsActive = admin.IsActive, // The soft delete flag
                    Roles = await _userManager.GetRolesAsync(admin)
                });
            }

            return View(adminViewModels);
        }

        // This is the Soft Delete action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ToggleActiveStatus(string id)
        {
            var admin = await _userManager.FindByIdAsync(id);
            if (admin != null)
            {
                admin.IsActive = !admin.IsActive; // Flip the status
                await _userManager.UpdateAsync(admin);
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateAdminViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    DisplayName = model.DisplayName,
                    UserName = model.UserName,
                    Email = model.Email,
                    IsActive = true // New admins are active by default
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    // This is the most important step: add the new user to the "Admin" role
                    await _userManager.AddToRoleAsync(user, "Admin");
                    return RedirectToAction(nameof(Index));
                }

                // If creation fails, add errors to ModelState to display them in the view
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay the form
            return View(model);
        }

    }
}