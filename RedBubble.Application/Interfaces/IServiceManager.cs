using RedBubble.Application.Interfaces.Products;
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
    }
}
