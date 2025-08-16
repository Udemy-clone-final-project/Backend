using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedBubble.Dashboard.Models;
// √÷› Â–« «·”ÿ—
using RedBubble.Domain.Entities.Models.Identity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RedBubble.Dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public HomeController(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                TotalUsers = await _userManager.Users.CountAsync(),
                TotalRoles = await _roleManager.Roles.CountAsync(),
                TotalAdmins = (await _userManager.GetUsersInRoleAsync("Admin")).Count
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}