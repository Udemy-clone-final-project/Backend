//using AutoMapper;
//using Microsoft.AspNetCore.Identity;
//using RedBubble.Application.DTOs.Identity;
//using RedBubble.Application.Interfaces;
//using RedBubble.Domain.Entities.Models;
//using RedBubble.Domain.Entities.Models.Identity;
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
//            var user = _mapper.Map<ApplicationUser>(ReqUser);

//            var result = await _userManager.CreateAsync(user, ReqUser.Password);
//            if (!result.Succeeded)
//                throw new Exception("Failed to create user: " + string.Join(", ", result.Errors.Select(e => e.Description)));

//            await _userManager.AddToRoleAsync(user, ReqUser.Role);

//            var token = await _tokenService.GenerateTokenAsync(user);

//            var loginResponse = _mapper.Map<LoginResponseDTO>(user);
//            loginResponse.AccessToken = token;
//            loginResponse.Role = ReqUser.Role;

//            return loginResponse;
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

//            var loginResponse = _mapper.Map<LoginResponseDTO>(user);
//            loginResponse.AccessToken = token;
//            loginResponse.Role = roles.FirstOrDefault();

//            return loginResponse;
//        }

//        public async Task UpdateUserAsync(AccountUpdateDTO ReqUser)
//        {
//            var user = await _userManager.FindByIdAsync(ReqUser.Id.ToString());
//            if (user == null)
//                throw new Exception("User not found");

//            _mapper.Map(ReqUser, user);

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

//            var userDto = _mapper.Map<UserDTO>(user);

//            // Map the role separately since it requires async call
//            var roles = await _userManager.GetRolesAsync(user);
//            userDto.Role = roles.FirstOrDefault();

//            return userDto;
//        }

//        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
//        {
//            var users = _userManager.Users.ToList();
//            var userDtos = _mapper.Map<IEnumerable<UserDTO>>(users);

//            // Map roles for each user
//            foreach (var userDto in userDtos)
//            {
//                var user = users.FirstOrDefault(u => u.Id == userDto.Id);
//                if (user != null)
//                {
//                    var roles = await _userManager.GetRolesAsync(user);
//                    userDto.Role = roles.FirstOrDefault();
//                }
//            }

//            return userDtos;
//        }
//    }
//}