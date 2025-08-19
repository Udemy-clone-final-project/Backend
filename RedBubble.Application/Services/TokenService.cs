

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

using Microsoft.IdentityModel.Tokens;

using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Identity;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Services
{
    public interface ITokenService
    {
        Task<string> GenerateTokenAsync(ApplicationUser user);
    }

    internal class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;

        public TokenService(IConfiguration configuration, UserManager<ApplicationUser> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }

        public async Task<string> GenerateTokenAsync(ApplicationUser user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email ?? ""),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var roles = await _userManager.GetRolesAsync(user);
            claims = claims.Concat(roles.Select(role => new Claim(ClaimTypes.Role, role))).ToArray();

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}