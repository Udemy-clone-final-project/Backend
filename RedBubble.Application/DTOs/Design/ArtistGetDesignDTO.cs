using RedBubble.Application.DTOs.Design.DesignImages;
using RedBubble.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.DTOs.Design
{
    public class ArtistGetDesignDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public DesignStatus Status { get; set; }
        public string? RejectionReason { get; set; }
        public DateTime UploadedAt { get; set; }
        public DateTime? ReviewedAt { get; set; } // Nullable because might not be reviewed yet
        public ICollection<DesignImageDto> Images { get; set; }
    }
}
