using RedBubble.Domain.Entities.Base;
using RedBubble.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Models
{
    public class Design : BaseEntity<Guid>
    {
        // public Guid Id { get; set; } — inherited from BaseEntity<Guid>
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public DesignStatus Status { get; set; }

        public DateTime UploadedAt { get; set; }

        public DateTime ReviewedAt { get; set; }

        public string? RejectionReason { get; set; } // only when DesignStatus Status = Status.Rejected

        #region Relationship 1-1 between Design and User(Artist)
        // Artist Creates

        // foreign key from User => Artist
        public Guid ArtistId { get; set; } // UploadedBy

        // navigation property 
        public ApplicationUser Artist { get; set; }
        #endregion

        #region Relationship 1-1 between Design and User(Admin)
        // Admin Reviews 

        // foreign key from User => Admin
        public Guid? AdminId { get; set; } // ReviewedBy
        // navigation property
        public ApplicationUser? Admin { get; set; }
        #endregion
    }
}
