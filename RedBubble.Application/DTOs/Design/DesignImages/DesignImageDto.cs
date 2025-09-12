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
        public string? FileName { get; set; }
        public string? AltText { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; } = true;
    }
    public class CreateDesignImageDto
    {
        public string? ImageUrl { get; set; }
        public string? FileName { get; set; }
        public string? AltText { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; } = true;
    }

    public class UpdateDesignImageDto
    {
        public int? Id { get; set; } 
        public string? ImageUrl { get; set; }
        public string? FileName { get; set; }
        public string? AltText { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; }
    }
}
