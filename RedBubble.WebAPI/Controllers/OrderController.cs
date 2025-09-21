using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.DTOs;
using RedBubble.Application.DTOs.Order;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;
using System.Security.Claims;

namespace RedBubble.WebAPI.Controllers
{
    [ApiController]
    [Route("api/orders")]
    [Authorize] // All actions in this controller require the user to be logged in
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        /// <summary>
        /// Creates a new order from a user's cart.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<OrderToReturnDto>> CreateOrder(OrderDto orderDto)
        {
            // Get the authenticated user's details from the JWT
            var userEmail = User.FindFirstValue(ClaimTypes.Email);
            var customerId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userEmail is null || customerId is null)
            {
                return Unauthorized("User identity not found in token.");
            }

            // Call the service to create the order in the database
            var order = await _orderService.CreateOrderAsync(userEmail, customerId, orderDto);

            if (order == null)
            {
                // This can happen if the cart is empty or an error occurs
                return BadRequest("A problem occurred while creating the order.");
            }

            // Map the Order entity to a DTO to return to the client
            var result = _mapper.Map<OrderToReturnDto>(order);

            return Ok(result);
        }

        /// <summary>
        /// Gets all orders for the currently logged-in user.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<OrderToReturnDto>>> GetOrdersForUser()
        {
            var customerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (customerId is null)
            {
                return Unauthorized("User is not authenticated.");
            }

            // Call the service to get the orders
            var orders = await _orderService.GetOrdersForUserAsync(customerId);

            // Map the list of entities to a list of DTOs
            var result = _mapper.Map<IReadOnlyList<OrderToReturnDto>>(orders);

            return Ok(result);
        }
    }
}