using AutoMapper;
using Microsoft.Extensions.Configuration;
using RedBubble.Application.DTOs.Cart;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Products;
using RedBubble.Domain.Entities.Models.Cart;
using RedBubble.Domain.Interfaces;
using StackExchange.Redis;
using System.Text.Json;

namespace RedBubble.Infrastructure.Implementations.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductVariantService _productVariantService;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

       
        private TimeSpan CartTimeToLive
        {
            get
            {
                var timeToLiveInDays = double.Parse(_configuration.GetSection("RedisSettings:TimeToLiveInDays").Value!);
                return TimeSpan.FromDays(timeToLiveInDays);
            }
        }

        public CartService(
            ICartRepository cartRepository,
            IProductVariantService productVariantService,
            IMapper mapper,
            IConfiguration configuration)
        {
            _cartRepository = cartRepository;
            _productVariantService = productVariantService;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<CustomerCartDto> GetCartAsync(string cartId)
        {
            CartItem cart =null;
            return _mapper.Map<CustomerCartDto>(cart);
        }

        //public async Task<CustomerCartDto> AddOrUpdateItemInCartAsync(string cartId, int variantId, int quantity)
        //{
        //    CartItem cart = null;
        //    //var existingItem = cart.Items.FirstOrDefault(item => item.VariantId == variantId);

        //    //if (existingItem != null)
        //    //{
        //    //    existingItem.Quantity = quantity;
        //    //}
        //    //else
        //    //{
        //    //    var productVariant = await _productVariantService.GetByIdAsync(variantId);
        //    //    if (productVariant == null)
        //    //    {
        //    //        throw new InvalidOperationException("Product is not available or out of stock.");
        //    //    }

        //    //    // ����� ��� �� ��� DTO ����� �� ProductVariant ���� ProductVariantDto
        //    //    // ������ ��� ������� ������� ������ ���������
        //    //    var newItem = new CartItem
        //    //    {
        //    //        VariantId = productVariant.Id,
        //    //        DesignTitle = productVariant.DesignTitle,
        //    //        ProductName = productVariant.BaseProductName,
        //    //        UnitPrice = productVariant.Price,
        //    //        Quantity = quantity,
        //    //        PictureUrl = productVariant.Images?.FirstOrDefault()?.ImageUrl ?? "",
        //    //        ColorName = productVariant.ColorName,
        //    //        SizeName = productVariant.SizeName
        //    //    };
        //    //    cart.Items.Add(newItem);
        //    //}

        //    // ������� ������� ������� ����� �� ����� �����
        //    //var updatedCart = await _cartRepository.UpdateCartAsync(cart, CartTimeToLive);

        //    return _mapper.Map<CustomerCartDto>(updatedCart);
        //}

        public async Task RemoveItemFromCartAsync(string cartId, int variantId)
        {
        //    var cart = await _cartRepository.GetCartAsync(cartId);
        //    if (cart == null) return;

        //    var itemToRemove = cart.Items.FirstOrDefault(item => item.VariantId == variantId);
        //    if (itemToRemove != null)
        //    {
        //        cart.Items.Remove(itemToRemove);

               
        //        await _cartRepository.UpdateCartAsync(cart, CartTimeToLive);
        //    }
        }

        public async Task<bool> DeleteCartAsync(string cartId)
        {
            return await _cartRepository.DeleteCartAsync(cartId);
        }

        public async Task MergeCartsAsync(string anonymousCartId, string customerId)
        {
            var anonymousCart = await _cartRepository.GetCartAsync(anonymousCartId);
            //var customerCart = await _cartRepository.GetCartAsync(customerId) ?? new CustomerCart { Id = customerId };

            //if (anonymousCart != null && anonymousCart.Items.Any())
            //{
            //    foreach (var item in anonymousCart.Items)
            //    {
            //        var existingItem = customerCart.Items.FirstOrDefault(i => i.VariantId == item.VariantId);
            //        if (existingItem != null)
            //        {
            //            existingItem.Quantity += item.Quantity; // ��� �������
            //        }
            //        else
            //        {
            //            customerCart.Items.Add(item);
            //        }
            //    }
            //}

           
            //await _cartRepository.UpdateCartAsync(customerCart, CartTimeToLive);
            await _cartRepository.DeleteCartAsync(anonymousCartId);
        }
    }
}
