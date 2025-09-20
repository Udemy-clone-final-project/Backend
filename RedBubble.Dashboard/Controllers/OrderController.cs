using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Services;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Orders;
using RedBubble.Domain.Enums;
using OrderStatus = RedBubble.Domain.Entities.Models.Orders.OrderStatus;



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

        public IActionResult Index()
        {
            return View();
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
            var result = await _orderService.ChangeStatus(orderId, status);

            if (result)
            {
                TempData["SuccessMessage"] = "Order status updated successfully.";
            }
            else
            {
                TempData["ErrorMessage"] = "Failed to update order status.";
            }

            return RedirectToAction(nameof(GetAll)); // reload the orders page
        }

        public async Task<IActionResult> Details(int id)
        {
            var order = await _orderService.GetByIdAsync(id);

            if (order == null)
            {
                TempData["ErrorMessage"] = "Order not found.";
                return RedirectToAction(nameof(GetAll));
            }

            return View(order);
        }
    }
}
