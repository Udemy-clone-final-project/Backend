using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.DTOs.Identity;
using RedBubble.Application.Interfaces; 
using RedBubble.Domain.Interfaces;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RedBubble.Domain.Entities.Models.Identity;
using System.Security.Claims;
using RedBubble.Application.Services;

namespace RedBubble.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITokenService _tokenService;

       
        public AccountController(IAccountService accountService, UserManager<ApplicationUser> userManager, ITokenService tokenService)
        {
            _accountService = accountService;
            _userManager = userManager;
            _tokenService = tokenService;
        }

        // POST: api/account/login
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            try
            {
                var userDto = await _accountService.LoginAsync(loginDto);
                return Ok(userDto);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
        }

        // POST: api/account/register
        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            try
            {
                var userDto = await _accountService.RegisterAsync(registerDto);
                return Ok(userDto);
            }
            catch (ArgumentException ex) 
            {
                return BadRequest(ex.Message);
            }
            catch (InvalidOperationException ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/account/me
        [Authorize]
        [HttpGet("me")]
        public async Task<ActionResult<ProfileDto>> GetMe()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId)) return Unauthorized();
            var id = userId!;
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            return Ok(new ProfileDto
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
                Phone = user.PhoneNumber
            });
        }

        // PUT: api/account/me
        [Authorize]
        [HttpPut("me")]
        public async Task<ActionResult<ProfileDto>> UpdateMe([FromBody] UpdateProfileDto dto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId)) return Unauthorized();
            var id = userId!;
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            if (!string.IsNullOrWhiteSpace(dto.DisplayName)) user.DisplayName = dto.DisplayName;
            if (!string.IsNullOrWhiteSpace(dto.Email)) user.Email = dto.Email;
            if (dto.Phone != null) user.PhoneNumber = dto.Phone;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                return BadRequest(string.Join(", ", result.Errors));
            }

            return Ok(new ProfileDto
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
                Phone = user.PhoneNumber
            });
        }

        // POST: api/account/change-password
        [Authorize]
        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest dto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId)) return Unauthorized();
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return NotFound();

            var result = await _userManager.ChangePasswordAsync(user, dto.CurrentPassword, dto.NewPassword);
            if (!result.Succeeded)
            {
                return BadRequest(string.Join(", ", result.Errors));
            }

            return NoContent();
        }

        // POST: api/account/refresh-token
        [HttpPost("refresh-token")]
        public async Task<ActionResult<RefreshTokenResponse>> RefreshToken([FromBody] RefreshTokenRequest request)
        {
            var newAccessToken = await _tokenService.RefreshAccessTokenAsync(request.RefreshToken);
            if (newAccessToken == null)
            {
                return Unauthorized("Invalid or expired refresh token");
            }

            return Ok(new RefreshTokenResponse
            {
                AccessToken = newAccessToken,
                RefreshToken = request.RefreshToken // Keep the same refresh token
            });
        }

        // DTOs moved to Application layer.
    }
}