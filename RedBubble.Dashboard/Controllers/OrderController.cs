using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Services;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Enums;

namespace RedBubble.Dashboard.Controllers
{
    [AllowAnonymous]
    public class OrderController : Controller
    {
        
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<IActionResult> GetAll()
        {
            var orders = await _orderService.GetAllAsync();
            return View(orders);
        }

        // changestatus , delete => make it as a dropdown list it calls the function in controller here 

        [HttpPost]
        public async Task<IActionResult> ChangeStatus(int orderId, OrderStatus status)
        {
            await _orderService.ChangeStatus(orderId, status);

            return RedirectToAction(nameof(GetAll)); // reload the orders page
        }




    }
}
