using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models.Cart;
using RedBubble.WebAPI.Models;
using Stripe;

namespace RedBubble.WebAPI.Controllers
{
   
    [ApiController]
    [Route("api/payments")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly IConfiguration _configuration;

        public PaymentsController(IPaymentService paymentService,IConfiguration configuration)
        {
            _paymentService = paymentService;
            _configuration = configuration;
        }

      
        [Authorize] 
        [HttpPost("{cartId}")]
        public async Task<ActionResult<CustomerCart>> CreateOrUpdatePaymentIntent(string cartId)
        {
            // Call the service to do the actual work of talking to Stripe
            var cart = await _paymentService.CreateOrUpdatePaymentIntentAsync(cartId);

            if (cart == null)
            {
                
                return BadRequest("A problem occurred with your cart.");
            }

            // Return the updated cart, which now includes the PaymentIntentId and ClientSecret
            return Ok(cart);
        }

        // Refund endpoint temporarily disabled. We'll re-enable when ready.

        [HttpPost("create-payment-intent")]
        public async Task<ActionResult<PaymentIntentResponse>> CreatePaymentIntent([FromBody] PaymentIntentRequest request)
        {
            try
            {
                // Configure Stripe (read from appsettings: StripeSettings:Secretkey)
                var secret = _configuration["StripeSettings:Secretkey"];
                if (string.IsNullOrWhiteSpace(secret))
                {
                    return BadRequest("Stripe secret key is not configured.");
                }
                StripeConfiguration.ApiKey = secret;

                var service = new PaymentIntentService();
                var options = new PaymentIntentCreateOptions
                {
                    Amount = request.Amount,
                    Currency = request.Currency,
                    Metadata = new Dictionary<string, string>
                    {
                        { "cartId", request.CartId }
                    }
                };

                var paymentIntent = await service.CreateAsync(options);
                
                var response = new PaymentIntentResponse
                {
                    ClientSecret = paymentIntent.ClientSecret,
                    PaymentIntentId = paymentIntent.Id
                };

                Console.WriteLine($"Created Payment Intent: {paymentIntent.Id}");
                Console.WriteLine($"Client Secret: {paymentIntent.ClientSecret}");

                return Ok(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating payment intent: {ex.Message}");
                return BadRequest($"Error creating payment intent: {ex.Message}");
            }
        }

        [HttpPost("confirm-payment")]
        public async Task<ActionResult<OrderResponse>> ConfirmPaymentAndCreateOrder([FromBody] OrderRequest request)
        {
            try
            {
                // For now, return a mock response
                var response = new OrderResponse
                {
                    OrderId = Guid.NewGuid().ToString(),
                    OrderNumber = "ORD-" + DateTime.Now.ToString("yyyyMMdd") + "-" + new Random().Next(1000, 9999),
                    Status = "completed",
                    TotalAmount = 100.00m, // This should be calculated from cart
                    EstimatedDelivery = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd")
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error creating order: {ex.Message}");
            }
        }

        [HttpGet("status/{paymentIntentId}")]
        public async Task<ActionResult<object>> GetPaymentStatus(string paymentIntentId)
        {
            try
            {
                // For now, return a mock response
                var status = new
                {
                    PaymentIntentId = paymentIntentId,
                    Status = "succeeded",
                    Amount = 100.00m,
                    Currency = "usd"
                };

                return Ok(status);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error getting payment status: {ex.Message}");
            }
        }
    
}
}
