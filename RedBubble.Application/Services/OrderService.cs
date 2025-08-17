using AutoMapper;
using RedBubble.Application.DTOs.Design;
using RedBubble.Application.DTOs.Order;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Enums;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IOrderRepository orderRepository , IMapper mapper , IUnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        // 9E85ED5F-9443-4471-888B-EE5A26E8A45D
        public async Task  CreateAsync(CreateOrderDTO createOrderDTO)
        {
            var order = _mapper.Map<Order>(createOrderDTO);

            // fake id for no 
            order.CustomerId = Guid.Parse("9E85ED5F-9443-4471-888B-EE5A26E8A45D");  //Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); // Logged-in user
            order.OrderDate = DateTime.UtcNow;
            order.Status = OrderStatus.Pending; // 0
            // to be continued when finish orderitems

            await _orderRepository.AddAsync(order);
            await _unitOfWork.CompleteAsync();

        }

        public async Task ChangeStatus(UpdateOrderDTO updateOrderDTO , Guid orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);

             _mapper.Map(updateOrderDTO, order);
            order.UpdatedAt = DateTime.UtcNow;

            _orderRepository.Update(order);
            await _unitOfWork.CompleteAsync();

        }

        public async Task Delete(Guid orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);

            order.Status = OrderStatus.Cancelled;
            order.UpdatedAt = DateTime.UtcNow;

            _orderRepository.Update(order);
            await _unitOfWork.CompleteAsync();

        }
    }
}
