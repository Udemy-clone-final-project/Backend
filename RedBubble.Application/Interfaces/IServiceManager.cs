using RedBubble.Application.Interfaces.Products;
using RedBubble.Application.Services;
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
        //public IUserService UserService { get; }
        
        public IProductVariantService ProductVariantService { get; }
        public IProductVariantImageService ProductVariantImageService { get; }
    //public ITokenService TokenService { get; }
}
}
