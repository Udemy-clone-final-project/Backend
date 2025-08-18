using RedBubble.Domain.Entities.Base;
using RedBubble.Domain.Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models
{
    public class DesignImage : BaseAuditableEntity<int>
    {
        public string? ImageUrl { get; set; }
        public string? FileName { get; set; }
        public string? AltText { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; }
        public int DsignId { get; set; }
        public Design Design { get; set; }
        
    }
}
