using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models.Cart
{
    public class CustomerCart
    {
        public string Id { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();
    }
}
