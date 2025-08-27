using AutoMapper;
using Microsoft.AspNetCore.Identity;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Products;
using RedBubble.Application.Interfaces.Services;
using RedBubble.Application.Services.Interfaces;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Identity;
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

        //private readonly Lazy<IUserService> _userService;
        

      

        private readonly Lazy<IBaseProductService> _baseProductService;
        private readonly Lazy<IProductVariantService> _productVariantService;
        private readonly Lazy<ICategoryService> _categoryService;

        private readonly Lazy<IColorService> _colorService;


        private readonly Lazy<ISizeService> _sizeService;
        private readonly Lazy<IDesignService> _designService;
        private readonly Lazy<IOrderService> _orderService;


        //private readonly Lazy<IProductVariantImageService> _productVariantImageService;


        public ServiceManager(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ITokenService tokenService,
            Lazy<IBaseProductService> baseProductService,
            Lazy<IProductVariantService> productVariantService,
            Lazy<ICategoryService> categoryService,
            Lazy<IColorService> colorService,
            Lazy<ISizeService> sizeService,
            Lazy<IDesignService> designService,
            Lazy<IOrderService> orderService

            //Lazy<IProductVariantImageService> productVariantImageService
            //Lazy<IUserService> userService
            )
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.tokenService = tokenService;
            _baseProductService = baseProductService;
            _productVariantService = productVariantService;
            _categoryService = categoryService;
            _colorService = colorService;
            _sizeService = sizeService;
            _designService = designService;
            _orderService = orderService;
            //_productVariantImageService = productVariantImageService;
            //_userService = userService;

        }
        //public IUserService UserService => _userService.Value;

        public IBaseProductService baseProductService => _baseProductService.Value;
        public IProductVariantService productVariantService => _productVariantService.Value;

        public ICategoryService categoryService => _categoryService.Value;

        public IColorService colorService => _colorService.Value;

        public ISizeService sizeService => _sizeService.Value;

        public IDesignService designService => _designService.Value;

        public IOrderService orderService => _orderService.Value;
        //public IProductVariantImageService ProductVariantImageService => _productVariantImageService.Value;

    }
}