//using AutoMapper;
//using Microsoft.AspNetCore.Identity;
//using RedBubble.Application.DTOs.User;
//using RedBubble.Application.Interfaces;
//using RedBubble.Domain.Entities.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace RedBubble.Application.Services
//{
//    internal class UserService : IUserService
//    {
//        private readonly UserManager<ApplicationUser> _userManager;
//        private readonly SignInManager<ApplicationUser> _signInManager;
//        private readonly IMapper _mapper;
//        private readonly ITokenService _tokenService;

//        public UserService(
//            UserManager<ApplicationUser> userManager,
//            SignInManager<ApplicationUser> signInManager,
//            IMapper mapper,
//            ITokenService tokenService)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//            _mapper = mapper;
//            _tokenService = tokenService;
//        }

//        public async Task<LoginResponseDTO> RegisterAsync(AccountCreateDTO ReqUser)
//        {
//            var user = new ApplicationUser
//            {
//                FirstName = ReqUser.FirstName,
//                LastName = ReqUser.LastName,
//                Email = ReqUser.Email,
//                UserName = ReqUser.UserName ?? ReqUser.Email,
//                IsActive = true,
//                CreatedOn = DateTime.UtcNow,
//                LastModifiedOn = DateTime.UtcNow
//            };

//            var result = await _userManager.CreateAsync(user, ReqUser.Password);
//            if (!result.Succeeded)
//                throw new Exception("Failed to create user: " + string.Join(", ", result.Errors.Select(e => e.Description)));

//            await _userManager.AddToRoleAsync(user, ReqUser.Role);

//            var token = await _tokenService.GenerateTokenAsync(user);

//            return new LoginResponseDTO
//            {
//                Id = user.Id,
//                UserName = user.UserName,
//                Email = user.Email,
//                FirstName = user.FirstName,
//                LastName = user.LastName,
//                AccessToken = token,
//                Role = ReqUser.Role
//            };
//        }

//        public async Task<LoginResponseDTO> LoginAsync(AccountLoginDTO ReqUser)
//        {
//            var user = await _userManager.FindByNameAsync(ReqUser.UserNameOrEmail) ??
//                       await _userManager.FindByEmailAsync(ReqUser.UserNameOrEmail);

//            if (user == null)
//                throw new Exception("User not found");

//            var result = await _signInManager.CheckPasswordSignInAsync(user, ReqUser.Password, false);
//            if (!result.Succeeded)
//                throw new Exception("Invalid password");

//            var token = await _tokenService.GenerateTokenAsync(user);
//            var roles = await _userManager.GetRolesAsync(user);

//            return new LoginResponseDTO
//            {
//                Id = user.Id,
//                UserName = user.UserName,
//                Email = user.Email,
//                FirstName = user.FirstName,
//                LastName = user.LastName,
//                AccessToken = token,
//                Role = roles.FirstOrDefault()
//            };
//        }

//        public async Task UpdateUserAsync(AccountUpdateDTO ReqUser)
//        {
//            var user = await _userManager.FindByIdAsync(ReqUser.Id.ToString());
//            if (user == null)
//                throw new Exception("User not found");

//            user.FirstName = ReqUser.FirstName;
//            user.LastName = ReqUser.LastName;
//            user.Email = ReqUser.Email;
//            user.LastModifiedOn = DateTime.UtcNow;

//            var result = await _userManager.UpdateAsync(user);
//            if (!result.Succeeded)
//                throw new Exception("Failed to update user: " + string.Join(", ", result.Errors.Select(e => e.Description)));
//        }

//        public async Task ChangePasswordAsync(ChangePasswordDTO dto)
//        {
//            var user = await _userManager.FindByIdAsync(dto.Id.ToString());
//            if (user == null)
//                throw new Exception("User not found");

//            var result = await _userManager.ChangePasswordAsync(user, dto.CurrentPassword, dto.NewPassword);
//            if (!result.Succeeded)
//                throw new Exception("Failed to update user: " + string.Join(", ", result.Errors.Select(e => e.Description)));
//        }

//        public async Task<UserDTO> GetUserByIdAsync(Guid id)
//        {
//            var user = await _userManager.FindByIdAsync(id.ToString());
//            if (user == null)
//                throw new Exception("User not found");

//            return _mapper.Map<UserDTO>(user);
//        }

//        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
//        {
//            var users = _userManager.Users.ToList();
//            return _mapper.Map<IEnumerable<UserDTO>>(users);
//        }
//    }
//}