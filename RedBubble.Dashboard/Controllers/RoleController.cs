using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedBubble.Dashboard.Models;
using RedBubble.Domain.Entities.Models.Identity;
using System.Threading.Tasks;

namespace RedBubble.Dashboard.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;

        public RoleController(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                TempData["Error"] = "Role name is required";
                return RedirectToAction(nameof(Index));
            }

            var role = new ApplicationRole
            {
                Name = name.Trim(),
                Description = description?.Trim()
            };

            var result = await _roleManager.CreateAsync(role);

            if (!result.Succeeded)
            {
                TempData["Error"] = result.Errors.FirstOrDefault()?.Description;
            }

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest();

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                return NotFound();

            var model = new RoleViewModel
            {
                Id = role.Id,
                Name = role.Name,
                Description = role.Description
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RoleViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // إرجاع النموذج مع أخطاء التحقق
                return View(model);
            }

            var role = await _roleManager.FindByIdAsync(model.Id);
            if (role == null)
            {
                ModelState.AddModelError(string.Empty, "Role not found.");
                return View(model);
            }

            // التحقق من عدم تكرار الاسم
            var existingRole = await _roleManager.FindByNameAsync(model.Name);
            if (existingRole != null && existingRole.Id != model.Id)
            {
                ModelState.AddModelError("Name", "Role name is already taken.");
                return View(model);
            }

            role.Name = model.Name.Trim();
            role.Description = model.Description?.Trim();

            var result = await _roleManager.UpdateAsync(role);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }

            TempData["SuccessMessage"] = "Role updated successfully";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest();

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
                return NotFound();

            var result = await _roleManager.DeleteAsync(role);
            if (!result.Succeeded)
            {
                TempData["ErrorMessage"] = "Failed to delete the role.";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}