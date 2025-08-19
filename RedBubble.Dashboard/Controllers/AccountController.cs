using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Dashboard.Models;
using RedBubble.Dashboard.Services;
using RedBubble.Domain.Entities.Models.Identity;
using System.Threading.Tasks;

namespace RedBubble.Dashboard.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, IEmailSender emailSender)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _emailSender = emailSender;
        }

        // GET: /Account/Login
        [AllowAnonymous] // Allow anyone to see the login page
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                // Step 1: Find the user by their email address first.
                var user = await _userManager.FindByEmailAsync(model.Email);

                // Step 2: Check if a user was found with that email and if their account is active.
                if (user == null || !user.IsActive)
                {
                    // We use the same generic error message for security reasons.
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }

                // Step 3: Attempt to sign in using the user's actual UserName, not their email.
                var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }

            // If model state is invalid, return the view with errors.
            return View(model);
        }

        // POST: /Account/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
        public async Task<IActionResult> Settings()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                // This should not happen for a logged-in user
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var model = new AdminSettingsViewModel
            {
                DisplayName = user.DisplayName,
                UserName = user.UserName,
                Email = user.Email
            };

            return View(model);
        }

        // POST: /Account/Settings
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Settings(AdminSettingsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            // Update the properties that can be changed
            user.DisplayName = model.DisplayName;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }

            // Add a success message and refresh the page
            TempData["SuccessMessage"] = "Your profile has been updated successfully.";
            return RedirectToAction(nameof(Settings));
        }
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        // POST: /Account/ForgotPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    // Generate the password reset token
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user);

                    // Create the password reset link
                    var callbackUrl = Url.Action("ResetPassword", "Account",
                        new { email = user.Email, token = token }, protocol: Request.Scheme);

                    // Send the email using the service we created
                    await _emailSender.SendEmailAsync(model.Email, "Reset Your Password",
                        $"Please reset your password by clicking this link: <a href='{callbackUrl}'>Reset Password</a>");
                }

                // To prevent attackers from knowing which emails are registered,
                // we always redirect to a confirmation page, even if the user doesn't exist.
                return RedirectToAction("ForgotPasswordConfirmation");
            }

            return View(model);
        }

       
        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }
 

        // GET: /Account/ResetPassword
        [AllowAnonymous]
        public IActionResult ResetPassword(string token, string email)
        {
            if (token == null || email == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid password reset token.");
            }
            // Pass the token and email to the view
            return View(new ResetPasswordViewModel { Token = token, Email = email });
        }

        // POST: /Account/ResetPassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    // Attempt to reset the password
                    var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
                    if (result.Succeeded)
                    {
                        // Redirect to a confirmation page on success
                        return RedirectToAction("ResetPasswordConfirmation");
                    }
                    // Add errors if the token is invalid or the password doesn't meet requirements
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View(model);
                }
            }
            // If model state is invalid, redisplay the form
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }
    }
}