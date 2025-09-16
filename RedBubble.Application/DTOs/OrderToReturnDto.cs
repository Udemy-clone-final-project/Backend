using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs
{
    public class OrderToReturnDto
    {
        public int Id { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime OrderDate { get; set; }
        public AddressDto ShippingAddress { get; set; } // سنعيد استخدام AddressDto
        public string DeliveryMethod { get; set; }
        public decimal ShippingPrice { get; set; }
        public List<OrderItemDto> Items { get; set; } // سنحتاج لـ OrderItemDto
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
    }

    // ستحتاج أيضًا لهذا الـ DTO ليمثل المنتجات داخل الطلب المُرجع
    public class OrderItemDto
    {
        public int VariantId { get; set; }
        public string DesignTitle { get; set; }
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
