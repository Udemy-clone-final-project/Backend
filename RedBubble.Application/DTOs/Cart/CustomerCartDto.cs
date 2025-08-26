using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Cart
{
    public class CustomerCartDto
    {
        /// <summary>
        /// سيكون هذا هو GUID للزائر أو CustomerId للمستخدم المسجل.
        /// </summary>
        public string Id { get; set; }
        public List<CartItemDto> Items { get; set; } = new List<CartItemDto>();

        /// <summary>
        /// السعر الإجمالي لكل المنتجات في السلة، يتم حسابه تلقائيًا.
        /// </summary>
        public decimal TotalPrice => Items.Sum(item => item.Subtotal);
    }
}
