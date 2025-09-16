using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.DTOs.Cart;
using RedBubble.Application.Interfaces;
using System.Security.Claims; 

namespace RedBubble.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        
        [HttpGet]
        public async Task<ActionResult<CustomerCartDto>> GetCart(
            [FromHeader(Name = "x-cart-id")] string? cartId)
        {
            if (string.IsNullOrEmpty(cartId))
            {
              
                return Ok(new CustomerCartDto { Id = null, Items = new() });
            }

            var cart = await _cartService.GetCartAsync(cartId);
            return Ok(cart);
        }

      
        [HttpPost]
        public async Task<ActionResult<CustomerCartDto>> AddOrUpdateItem(
            [FromBody] AddItemDto addItemDto,
            [FromHeader(Name = "x-cart-id")] string? cartId)
        {
            Console.WriteLine($"Received cart ID: {cartId}");
            
            var finalCartId = string.IsNullOrEmpty(cartId) ? Guid.NewGuid().ToString() : cartId;
            Console.WriteLine($"Final cart ID: {finalCartId}");

            var updatedCart = await _cartService.AddOrUpdateItemInCartAsync(finalCartId, addItemDto.VariantId, addItemDto.Quantity);

            // Set the cart ID in the response headers
            Response.Headers.Add("X-Cart-Id", finalCartId);
            Console.WriteLine($"Sending cart ID in header: {finalCartId}");
            
            // Also set the cart ID in the response body
            updatedCart.Id = finalCartId;
            
            return Ok(updatedCart);
        }

        
        [HttpDelete("items/{variantId}")]
        public async Task<IActionResult> RemoveItem(
            int variantId,
            [FromHeader(Name = "x-cart-id")] string? cartId)
        {
            if (string.IsNullOrEmpty(cartId))
            {
                
                return BadRequest("Cart ID is missing.");
            }

            await _cartService.RemoveItemFromCartAsync(cartId, variantId);
            return NoContent();
        }

       
    }
}
