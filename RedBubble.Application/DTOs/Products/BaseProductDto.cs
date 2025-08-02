using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Products
{
    public class BaseProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal BasePrice { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
    public class CreateBaseProductDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(500)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(0.01, 10000.00)]
        public decimal BasePrice { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
