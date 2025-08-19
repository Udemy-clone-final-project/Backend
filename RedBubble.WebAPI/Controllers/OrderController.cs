using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.DTOs.Order;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;

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

        [HttpPost("{orderId}")]
        public async Task<IActionResult> ChangeStatus(UpdateOrderDTO updateOrderDTO , int orderId)
        {
            await _orderService.ChangeStatus(updateOrderDTO, orderId);
            return Ok();

        }

        [HttpDelete("{orderId}")]

        public async Task<IActionResult> Delete(int orderId)
        {
            await _orderService.Delete(orderId);
            return Ok();

        }
    }
} 
