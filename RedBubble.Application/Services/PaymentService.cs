using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Cart;
using RedBubble.Domain.Entities.Models.Orders;
using RedBubble.Domain.Interfaces;
using Stripe;

namespace RedBubble.Application.Services
{
    
    public class PaymentService : IPaymentService
    {
        private readonly IConfiguration _config;
        private readonly ICartRepository _cartRepository; 
        private readonly IUnitOfWork _unitOfWork;

      
        public PaymentService(IConfiguration config, IUnitOfWork unitOfWork, ICartRepository cartRepository)
        {
            _config = config;
            _unitOfWork = unitOfWork;
            _cartRepository = cartRepository;
        }

        
        public async Task<CustomerCart?> CreateOrUpdatePaymentIntentAsync(string cartId)
        {
            StripeConfiguration.ApiKey = _config["StripeSettings:SecretKey"];

            var cart = await _cartRepository.GetCartAsync(cartId);
            if (cart == null) return null;

            decimal shippingPrice = 0;
            if (cart.DeliveryMethodId.HasValue)
            {
                var deliveryMethod = await _unitOfWork.GetRepository<DeliveryMethod, int>().GetByIdAsync(cart.DeliveryMethodId.Value);
                shippingPrice = deliveryMethod.Cost;
            }

            var subtotal = cart.Items.Sum(i => i.Quantity * i.UnitPrice);
            var totalAmount = (long)((subtotal + shippingPrice) * 100);

            var service = new PaymentIntentService();
            PaymentIntent intent;

            if (string.IsNullOrEmpty(cart.PaymentIntentId))
            {
                var options = new PaymentIntentCreateOptions { Amount = totalAmount, Currency = "usd", PaymentMethodTypes = new List<string> { "card" } };
                intent = await service.CreateAsync(options);
                cart.PaymentIntentId = intent.Id;
                cart.ClientSecret = intent.ClientSecret;
            }
            else
            {
                var options = new PaymentIntentUpdateOptions { Amount = totalAmount };
                intent = await service.UpdateAsync(cart.PaymentIntentId, options);
            }

            await _cartRepository.UpdateCartAsync(cart, TimeSpan.FromDays(15));
            return cart;
        }
    }
}