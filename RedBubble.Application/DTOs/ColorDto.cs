using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs
{
    public class ColorDto
    {
        public int Id { get; set; }
        public string ColorName { get; set; } = null!;
        public string ColorCode { get; set; } = null!;
        public bool IsActive { get; set; }
    }

    public class CreateColorDto
    {
        public string ColorName { get; set; } = null!;
        public string ColorCode { get; set; } = null!;
        public bool IsActive { get; set; } = true;
    }

    public class UpdateColorDto
    {
        public int Id { get; set; }
        public string ColorName { get; set; } = null!;
        public string ColorCode { get; set; } = null!;
        public bool IsActive { get; set; }
    }




}