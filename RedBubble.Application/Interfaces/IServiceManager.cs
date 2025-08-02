using RedBubble.Application.Interfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces
{
    public class IServiceManager
    {
        public IBaseProductService baseProductService { get; }
    }
}
