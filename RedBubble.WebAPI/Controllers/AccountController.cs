using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.DTOs.Identity;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Services;
using RedBubble.Domain.Entities.Models.Identity;

namespace RedBubble.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ITokenService _tokenService;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        // POST: api/account/login
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null) return Unauthorized("Invalid Email or Password");

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if (!result.Succeeded) return Unauthorized("Invalid Email or Password");

            return new UserDto
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
                Token = await _tokenService.GenerateTokenAsync(user)
            };
        }

        // POST: api/account/register
        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            var existingUser = await _userManager.FindByEmailAsync(registerDto.Email);
            if (existingUser != null)
            {
                return BadRequest("Email address is already in use.");
            }

            var user = new ApplicationUser
            {
                DisplayName = registerDto.DisplayName,
                Email = registerDto.Email,
                UserName = registerDto.Email, // Often set username to email by default
                EmailConfirmed = true // Or implement email confirmation flow
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            

            return new UserDto
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
                Token = "Please log in to generate a token" // No token on registration
            };
        }


    }
}
