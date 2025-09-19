using Microsoft.AspNetCore.Identity;
using RedBubble.Application.DTOs.Identity;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models.Identity;
using RedBubble.Domain.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RedBubble.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ITokenService _tokenService;

        public AccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task<UserDto> LoginAsync(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null)
            {
                
                throw new UnauthorizedAccessException("Invalid Email or Password");
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if (!result.Succeeded)
            {
                throw new UnauthorizedAccessException("Invalid Email or Password");
            }

            var (accessToken, refreshToken) = await _tokenService.GenerateTokenPairAsync(user);
            return new UserDto
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
                Token = accessToken,
                RefreshToken = refreshToken
            };
        }

        public async Task<UserDto> RegisterAsync(RegisterDto registerDto)
        {
            var existingUser = await _userManager.FindByEmailAsync(registerDto.Email);
            if (existingUser != null)
            {
               
                throw new ArgumentException("Email address is already in use.");
            }

            var user = new ApplicationUser
            {
                DisplayName = registerDto.DisplayName,
                Email = registerDto.Email,
                UserName = registerDto.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
            {
                
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new InvalidOperationException($"Failed to create user: {errors}");
            }

            var (accessToken, refreshToken) = await _tokenService.GenerateTokenPairAsync(user);
            return new UserDto
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
                Token = accessToken,
                RefreshToken = refreshToken
            };
        }
    }
}