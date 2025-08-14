using AutoMapper;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Products;
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
        private readonly Lazy<IBaseProductService> _baseProductService;

        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper, Lazy<IBaseProductService> baseProductService)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            _baseProductService = baseProductService;
        }

        public IBaseProductService baseProductService => _baseProductService.Value;

    }
}

#region Why we use Service manager , why is important ?
// This ServiceManager class is a central point to access services — it acts like a service container/facade.

// controller code before service manager vs after service manager
// before : You inject every service separately, making the constructor long and messy as the project grows.
//public class ProductController : ControllerBase
//{
//    private readonly IBaseProductService _baseProductService;
//    private readonly ICategoryService _categoryService;
//    private readonly IUserService _userService;

//    public ProductController(
//        IBaseProductService baseProductService,
//        ICategoryService categoryService,
//        IUserService userService)
//    {
//        _baseProductService = baseProductService;
//        _categoryService = categoryService;
//        _userService = userService;
//    }

//    public async Task<IActionResult> GetAll()
//    {
//        var products = await _baseProductService.GetAllAsync();
//        return Ok(products);
//    }
//}

// after : code is clean 
//public class ProductController : ControllerBase
//{
//    private readonly IServiceManager _service;

//    public ProductController(IServiceManager service)
//    {
//        _service = service;
//    }

//    public async Task<IActionResult> GetAll()
//    {
//        var products = await _service.baseProductService.GetAllAsync();
//        return Ok(products);
//    }
//}

#endregion