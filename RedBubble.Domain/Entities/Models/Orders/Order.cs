using RedBubble.Domain.Entities.Base;
using RedBubble.Domain.Entities.Models.Identity;
using RedBubble.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models.Orders
{
    // Domain/Entities/Models/Order.cs
    public class Order : BaseAuditableEntity<int>
    {
        private Order() { } // لـ EF Core

        public Order(string customerId, Address shippingAddress, DeliveryMethod deliveryMethod, ICollection<OrderItem> orderItems, decimal subtotal, string? paymentIntentId)
        {
            CustomerId = customerId;
            ShippingAddress = shippingAddress;
            DeliveryMethod = deliveryMethod;
            OrderItems = orderItems;
            Subtotal = subtotal;
            PaymentIntentId = paymentIntentId;
        }

        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public decimal Subtotal { get; set; }

        // علاقة مع المستخدم
        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }

        // علاقة مع عنوان الشحن
        public Address ShippingAddress { get; set; }

        // علاقة مع طريقة التوصيل
        public int ?DeliveryMethodId { get; set; }
        public DeliveryMethod? DeliveryMethod { get; set; }

        // علاقة مع منتجات الطلب
        public ICollection<OrderItem> OrderItems { get; set; }

        // للربط مع Stripe
        public string? PaymentIntentId { get; set; }

        // دالة مساعدة لحساب المجموع الإجمالي
        public decimal GetTotal() => Subtotal + DeliveryMethod.Cost;
    }
}
