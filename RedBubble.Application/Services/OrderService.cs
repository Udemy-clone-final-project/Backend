using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedBubble.Application.DTOs;
using RedBubble.Application.DTOs.Design;
using RedBubble.Application.DTOs.Order;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models.Orders;
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
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;
        private readonly IPaymentService _paymentService;
        private readonly ICurrentUserService _currentUserService;
        public OrderService(IUnitOfWork unitOfWork, ICartRepository cartRepository, IMapper mapper, IPaymentService paymentService, ICurrentUserService currentUserService)
        {
            _unitOfWork = unitOfWork;
            _cartRepository = cartRepository;
            _mapper = mapper;
            _paymentService = paymentService;
            _currentUserService = currentUserService;
        }

        public async Task<Order?> CreateOrderAsync(string customerEmail, string customerId, OrderDto orderDto)
        {
            // الخطوة 1: جلب السلة من Redis (كما هي)
            //var cart = await _cartRepository.GetCartAsync(orderDto.CartId);
            //if (cart == null || !cart.Items.Any()) return null;

            var cart = await _cartRepository.GetCartAsync(orderDto.CartId);
            if (cart == null || !cart.Items.Any()) return null;


            var orderItems = new List<OrderItem>();
            foreach (var item in cart.Items)
            {
                var variantOrdered = new VariantItemOrdered(
                    item.VariantId,
                    item.DesignTitle,
                    item.ProductName,
                    item.PictureUrl ?? "",
                    item.ColorName,
                    item.SizeName
                );
                var orderItem = new OrderItem(variantOrdered, item.UnitPrice, item.Quantity);
                orderItems.Add(orderItem);
            }


            var deliveryMethod = await _unitOfWork.GetRepository<DeliveryMethod, int>().GetByIdAsync(orderDto.DeliveryMethodId);
            if (deliveryMethod == null) throw new Exception("Delivery method not found.");


            var subtotal = orderItems.Sum(oi => oi.Price * oi.Quantity);

            // ✨ الخطوة 5: التحقق من وجود طلب قديم بنفس عملية الدفع (المنطق الجديد)
            //var orderRepo = _unitOfWork.GetRepository<Order, int>();
            //if (!string.IsNullOrEmpty(cart.PaymentIntentId))
            //{
            //    var existingOrder = await orderRepo.GetAll()
            //                                       .FirstOrDefaultAsync(o => o.PaymentIntentId == cart.PaymentIntentId);

            var orderRepo = _unitOfWork.GetRepository<Order, int>();
            if (!string.IsNullOrEmpty(cart.PaymentIntentId))
            {
                var existingOrder = await orderRepo.GetAll()
                                                   .FirstOrDefaultAsync(o => o.PaymentIntentId == cart.PaymentIntentId);

                if (existingOrder != null)
                {

                    orderRepo.Delete(existingOrder);

                    await _paymentService.CreateOrUpdatePaymentIntentAsync(orderDto.CartId);
                }
            }


            var shippingAddress = _mapper.Map<Address>(orderDto.ShippingAddress);
            var order = new Order(customerId, shippingAddress, deliveryMethod, orderItems, subtotal, cart.PaymentIntentId);


            await orderRepo.AddAsync(order);
            var result = await _unitOfWork.CompleteAsync();

            if (result <= 0) return null;

            return order;
        }
        public async Task<IReadOnlyList<Order>> GetOrdersForUserAsync(string customerId)
        {
            var orderRepo = _unitOfWork.GetRepository<Order, int>();


            var orders = await orderRepo.GetAll()
                .Where(o => o.CustomerId == customerId)
                .Include(o => o.DeliveryMethod)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.ProductVariantOrdered)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();

            return orders;
        }

        public async Task<IReadOnlyList<Order>> GetAllAsync()
        {
            var orderRepo = _unitOfWork.GetRepository<Order, int>();

            var orders = await orderRepo.GetAll()
                .Include(o => o.DeliveryMethod)
                .Include(o => o.ShippingAddress)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.ProductVariantOrdered)
                .Include(o => o.Customer)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();

            return orders;
        }

        public async Task<Order?> GetByIdAsync(int orderId)
        {
            var orderRepo = _unitOfWork.GetRepository<Order, int>();

            var order = await orderRepo.GetAll()
                .Include(o => o.DeliveryMethod)
                .Include(o => o.ShippingAddress)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.ProductVariantOrdered)
                .Include(o => o.Customer)
                .FirstOrDefaultAsync(o => o.Id == orderId);

            return order;
        }

        public async Task<bool> ChangeStatus(int orderId, OrderStatus status)
        {
            var orderRepo = _unitOfWork.GetRepository<Order, int>();
            var order = await orderRepo.GetByIdAsync(orderId);

            if (order == null) return false;

            order.Status = status;
            // Ensure audit fields are set to satisfy NOT NULL constraints
            if (string.IsNullOrWhiteSpace(order.CreatedBy))
            {
                order.CreatedBy = _currentUserService.UserId ?? "system";
            }
            if (order.CreatedOn == default)
            {
                order.CreatedOn = DateTime.UtcNow;
            }
            order.LastModifiedBy = _currentUserService.UserId ?? "system";
            order.LastModifiedOn = DateTime.UtcNow;
            orderRepo.Update(order);

            var result = await _unitOfWork.CompleteAsync();

            // Verify persisted value from database
            var refreshed = await orderRepo.GetByIdAsync(orderId);
            return result > 0 && refreshed != null && refreshed.Status == status;
        }
    }
    }
