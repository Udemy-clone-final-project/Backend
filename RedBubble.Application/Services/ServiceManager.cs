using AutoMapper;
using Microsoft.AspNetCore.Identity;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Products;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Services
{
    internal class ServiceManager : IServiceManager
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ITokenService tokenService;

        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IRoleService> _roleService;

        private readonly Lazy<IBaseProductService> _baseProductService;
        private readonly Lazy<IProductVariantService> _productVariantService;
        private readonly Lazy<IProductVariantImageService> _productVariantImageService;


        public ServiceManager(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ITokenService tokenService,
            Lazy<IBaseProductService> baseProductService,
            Lazy<IProductVariantService> productVariantService,
            Lazy<IProductVariantImageService> productVariantImageService,
            Lazy<IUserService> userService,
            Lazy<IRoleService> roleService)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.tokenService = tokenService;
            _baseProductService = baseProductService;
            _productVariantService = productVariantService;
            _productVariantImageService = productVariantImageService;
            _userService = userService;
            _roleService = roleService;
        }
        public IUserService UserService => _userService.Value;
        public IRoleService RoleService => _roleService.Value;
        public IBaseProductService baseProductService => _baseProductService.Value;
        public IProductVariantService ProductVariantService => _productVariantService.Value;
        public IProductVariantImageService ProductVariantImageService => _productVariantImageService.Value;

    }
}