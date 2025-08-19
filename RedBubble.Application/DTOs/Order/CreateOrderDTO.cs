using RedBubble.Application.DTOs.OrderItem;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Order
{
    public class CreateOrderDTO
    {  
        public string ShippingAddress { get; set; }
        public string ShippingCity { get; set; }

        public string ShippingCountry { get; set; }
        public string ShippingPostalCode { get; set; }

        public List<CreateOrderItemDTO> OrderItems { get; set; }  
    }
}
