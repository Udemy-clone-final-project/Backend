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
        //private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;
        //private readonly IPaymentService _paymentService;
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            //_cartRepository = cartRepository;
            _mapper = mapper;
            //_paymentService = paymentService;
        }

        public async Task<Order?> CreateOrderAsync(string customerEmail, string customerId, OrderDto orderDto)
        {
            // الخطوة 1: جلب السلة من Redis (كما هي)
            //var cart = await _cartRepository.GetCartAsync(orderDto.CartId);
            //if (cart == null || !cart.Items.Any()) return null;

            // الخطوة 2: إنشاء قائمة بـ OrderItems (كما هي، طريقتك هنا فعالة)
            var orderItems = new List<OrderItem>();
            //foreach (var item in cart.Items)
            //{
            //    var variantOrdered = new VariantItemOrdered(item.VariantId, item.DesignTitle, item.ProductName, item.PictureUrl);
            //    var orderItem = new OrderItem(variantOrdered, item.UnitPrice, item.Quantity);
            //    orderItems.Add(orderItem);
            //}

            // الخطوة 3: جلب طريقة التوصيل (كما هي)
            var deliveryMethod = await _unitOfWork.GetRepository<DeliveryMethod, int>().GetByIdAsync(orderDto.DeliveryMethodId);
            if (deliveryMethod == null) throw new Exception("Delivery method not found.");

            // الخطوة 4: حساب المجموع الفرعي (كما هي)
            var subtotal = orderItems.Sum(oi => oi.Price * oi.Quantity);

            // ✨ الخطوة 5: التحقق من وجود طلب قديم بنفس عملية الدفع (المنطق الجديد)
            //var orderRepo = _unitOfWork.GetRepository<Order, int>();
            //if (!string.IsNullOrEmpty(cart.PaymentIntentId))
            //{
            //    var existingOrder = await orderRepo.GetAll()
            //                                       .FirstOrDefaultAsync(o => o.PaymentIntentId == cart.PaymentIntentId);

            //    if (existingOrder != null)
            //    {
            //        // إذا وجدنا طلبًا قديمًا، نحذفه
            //        orderRepo.Delete(existingOrder);
            //        // ونقوم بتحديث المبلغ في Stripe ليعكس أي تغييرات في السلة
            //        await _paymentService.CreateOrUpdatePaymentIntentAsync(orderDto.CartId);
            //    }
            //}

            // الخطوة 6: إنشاء الطلب الجديد (كما هي)
            var shippingAddress = _mapper.Map<Address>(orderDto.ShippingAddress);
            Order order = null;

            // الخطوة 7: حفظ الطلب الجديد في قاعدة البيانات
            //await orderRepo.AddAsync(order);
            var result = await _unitOfWork.CompleteAsync();

            if (result <= 0) return null; // فشل الحفظ

            return order;
        }
        public async Task<IReadOnlyList<Order>> GetOrdersForUserAsync(string customerId)
        {
            var orderRepo = _unitOfWork.GetRepository<Order, int>();

            // نستخدم .Include لجلب البيانات المرتبطة من الجداول الأخرى
            var orders = await orderRepo.GetAll() // .GetAll() ترجع IQueryable
                .Where(o => o.CustomerId == customerId)
                .Include(o => o.DeliveryMethod) // تضمين بيانات طريقة التوصيل
                .Include(o => o.OrderItems) // تضمين قائمة المنتجات في الطلب
                    .ThenInclude(oi => oi.ProductVariantOrdered) // ✨ الأهم: تضمين تفاصيل المنتج المحفوظة
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();

            return orders;
        }
    }
    }
