using RedBubble.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Order
{
    public class UpdateOrderDTO
    {
        public OrderStatus Status { get; set; }
    }
}
