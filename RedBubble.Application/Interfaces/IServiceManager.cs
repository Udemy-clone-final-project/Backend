using RedBubble.Application.Interfaces.Products;
using RedBubble.Application.Interfaces.Services;
using RedBubble.Application.Services;
using RedBubble.Application.Services.Interfaces;
using RedBubble.Application.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces
{
    public interface IServiceManager
    {
        public IBaseProductService baseProductService { get; }
        public IProductVariantService productVariantService { get; }
        public ICategoryService categoryService { get; }
        public IColorService colorService { get; }
        public ISizeService sizeService { get; }
        public IDesignService designService { get; }
        public IOrderService orderService { get; }


        //public IProductVariantImageService ProductVariantImageService { get; }
        //public ITokenService TokenService { get; }
        //public IUserService UserService { get; }
    }
}
