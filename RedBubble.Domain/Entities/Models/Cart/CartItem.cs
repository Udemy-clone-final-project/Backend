using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models.Cart
{
    public class CartItem
    {
        public int VariantId { get; set; } 
        public string DesignTitle { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; } 
        public int Quantity { get; set; }
        public string ?PictureUrl { get; set; }
        public string ColorName { get; set; }
        public string SizeName { get; set; }
    }
}
