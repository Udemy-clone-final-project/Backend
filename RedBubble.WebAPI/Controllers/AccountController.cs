using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.DTOs.Identity;
using RedBubble.Application.Interfaces; 
using RedBubble.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace RedBubble.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

       
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
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
    }
}