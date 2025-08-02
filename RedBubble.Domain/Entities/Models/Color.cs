using RedBubble.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models
{

    public class Color : BaseEntity<int>
    {

        public string ColorName { get; set; } = null!;
        public string ColorCode { get; set; } = null!; // Hex Color Code
        public bool IsActive { get; set; }
    }

}