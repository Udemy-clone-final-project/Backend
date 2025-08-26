using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Cart
{

    public class AddItemDto
    {
        public int VariantId { get; set; }
        public int Quantity { get; set; }
    }
}
