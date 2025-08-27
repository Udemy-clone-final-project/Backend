using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.DTOs.Order;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Enums;

namespace RedBubble.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderDTO createOrderDTO)
        {
            await _orderService.CreateAsync(createOrderDTO);
            return Ok();
        }

        

        [HttpDelete("{orderId}")]

        public async Task<IActionResult> Delete(int orderId) // changestatus
        {
            
            await _orderService.Delete(orderId);
            return Ok();

        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetOrdersByCustomerId(string customerId)
        {
            var orders = await _orderService.GetOrdersByCustomerId(customerId);

            return Ok(orders);
        }
    }
} 
