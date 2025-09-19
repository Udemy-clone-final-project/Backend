

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

using Microsoft.IdentityModel.Tokens;
using RedBubble.Domain.Entities.Models.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RedBubble.Application.Services
{
    public interface ITokenService
    {
        Task<string> GenerateTokenAsync(ApplicationUser user);
        Task<(string AccessToken, string RefreshToken)> GenerateTokenPairAsync(ApplicationUser user);
        Task<string?> RefreshAccessTokenAsync(string refreshToken);
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
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email ?? string.Empty),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var roles = await _userManager.GetRolesAsync(user);
            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<(string AccessToken, string RefreshToken)> GenerateTokenPairAsync(ApplicationUser user)
        {
            var accessToken = await GenerateTokenAsync(user);
            var refreshToken = Guid.NewGuid().ToString();
            
            // Store refresh token in user's claims or separate table
            // For simplicity, we'll store it in a static dictionary (in production, use database)
            _refreshTokens[refreshToken] = new RefreshTokenInfo
            {
                UserId = user.Id.ToString(),
                ExpiresAt = DateTime.UtcNow.AddDays(7),
                IsRevoked = false
            };
            
            return (accessToken, refreshToken);
        }

        public async Task<string?> RefreshAccessTokenAsync(string refreshToken)
        {
            if (!_refreshTokens.TryGetValue(refreshToken, out var tokenInfo) || 
                tokenInfo.IsRevoked || 
                tokenInfo.ExpiresAt < DateTime.UtcNow)
            {
                return null;
            }

            var user = await _userManager.FindByIdAsync(tokenInfo.UserId);
            if (user == null) return null;

            return await GenerateTokenAsync(user);
        }

        private static readonly Dictionary<string, RefreshTokenInfo> _refreshTokens = new();

        private class RefreshTokenInfo
        {
            public string UserId { get; set; } = string.Empty;
            public DateTime ExpiresAt { get; set; }
            public bool IsRevoked { get; set; }
        }
    }
}