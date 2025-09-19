namespace RedBubble.WebAPI.Models
{
    public class PaymentIntentRequest
    {
        public int Amount { get; set; }
        public string Currency { get; set; } = "usd";
        public string CartId { get; set; } = string.Empty;
        public ShippingInfo ShippingInfo { get; set; } = new();
    }

    public class ShippingInfo
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ShippingType { get; set; } = "standard";
    }

    public class PaymentIntentResponse
    {
        public string ClientSecret { get; set; } = string.Empty;
        public string PaymentIntentId { get; set; } = string.Empty;
    }

    public class OrderRequest
    {
        public string CartId { get; set; } = string.Empty;
        public string PaymentIntentId { get; set; } = string.Empty;
        public ShippingInfo ShippingInfo { get; set; } = new();
        public BillingInfo BillingInfo { get; set; } = new();
    }

    public class BillingInfo
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }

    public class OrderResponse
    {
        public string OrderId { get; set; } = string.Empty;
        public string OrderNumber { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public string EstimatedDelivery { get; set; } = string.Empty;
    }

    public class RefundRequest
    {
        public string PaymentIntentId { get; set; } = string.Empty;
        public long? Amount { get; set; } // cents; null = full refund
        public string? Reason { get; set; }
    }

    public class RefundResponse
    {
        public bool Success { get; set; }
        public string RefundId { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
    }

    public class Order
    {
        public string Id { get; set; } = string.Empty;
        public string OrderNumber { get; set; } = string.Empty;
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }
        public string Currency { get; set; } = "USD";
        public string CreatedAt { get; set; } = string.Empty;
        public string EstimatedDelivery { get; set; } = string.Empty;
        public ShippingInfo ShippingInfo { get; set; } = new();
        public BillingInfo BillingInfo { get; set; } = new();
        public List<OrderItem> Items { get; set; } = new();
        public string PaymentIntentId { get; set; } = string.Empty;
    }

    public class OrderItem
    {
        public string Id { get; set; } = string.Empty;
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public string ProductImage { get; set; } = string.Empty;
        public string VariantId { get; set; } = string.Empty;
        public string VariantName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled,
        Refunded
    }

    //public class UserProfile
    //{
    //    public string Id { get; set; } = string.Empty;
    //    public string FirstName { get; set; } = string.Empty;
    //    public string LastName { get; set; } = string.Empty;
    //    public string Email { get; set; } = string.Empty;
    //    public string Phone { get; set; } = string.Empty;
    //    public string Avatar { get; set; } = string.Empty;
    //    public string DateJoined { get; set; } = string.Empty;
    //    public int TotalOrders { get; set; }
    //    public decimal TotalSpent { get; set; }
    //    public Address DefaultAddress { get; set; } = new();
    //}

    //public class Address
    //{
    //    public string Id { get; set; } = string.Empty;
    //    public string FirstName { get; set; } = string.Empty;
    //    public string LastName { get; set; } = string.Empty;
    //    public string Address { get; set; } = string.Empty;
    //    public string City { get; set; } = string.Empty;
    //    public string State { get; set; } = string.Empty;
    //    public string ZipCode { get; set; } = string.Empty;
    //    public string Country { get; set; } = string.Empty;
    //    public bool IsDefault { get; set; }
    //}
}
