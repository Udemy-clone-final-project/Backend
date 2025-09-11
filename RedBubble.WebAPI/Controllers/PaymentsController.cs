using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models.Cart;

namespace RedBubble.WebAPI.Controllers
{
   
    [ApiController]
    [Route("api/payments")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
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
    
}
}
