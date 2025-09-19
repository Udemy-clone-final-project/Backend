//using RedBubble.Domain.Entities.Models.Cart;
//using RedBubble.Domain.Interfaces;
//using StackExchange.Redis;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;

//namespace RedBubble.Infrastructure.Implementations.CartRepository
//{
//    public class CartRepository : ICartRepository
//    {
//        private readonly IDatabase _database;

//        public CartRepository(IConnectionMultiplexer redis)
//        {
//            _database = redis.GetDatabase();
//        }

//        public async Task<CustomerCart?> GetCartAsync(string cartId)
//        {
//            var data = await _database.StringGetAsync(cartId);
//            return data.IsNullOrEmpty ? null : JsonSerializer.Deserialize<CustomerCart>(data!);
//        }

//        public async Task<CustomerCart?> UpdateCartAsync(CustomerCart cart,TimeSpan timeToLive)
//        {
          
//            //var created = await _database.StringSetAsync(cart.Id, JsonSerializer.Serialize(cart), timeToLive);
//            if (!created) return null;

//            return await GetCartAsync(4);
//        }

//        public async Task<bool> DeleteCartAsync(string cartId)
//        {
//            return await _database.KeyDeleteAsync(cartId);
//        }
//    }
//}