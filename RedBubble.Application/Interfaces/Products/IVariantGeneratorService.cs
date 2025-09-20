using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces.Products
{


    public interface IVariantGeneratorService
    {
        Task GenerateVariantsAsync(int designId, int baseProductId);
    }


}