using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs
{
    public class SizeDto
    {
        public int Id { get; set; }
        public string SizeName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsActive { get; set; }
    }
    
    public class CreateSizeDto
    {
        public string SizeName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsActive { get; set; } = true;
    }
    
    public class UpdateSizeDto
    {
        public int Id { get; set; }
        public string SizeName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}