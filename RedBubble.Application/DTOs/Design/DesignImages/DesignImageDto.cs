using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Design.DesignImages
{
    public class DesignImageDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } 
        public bool IsPrimary { get; set; }
    }
}
