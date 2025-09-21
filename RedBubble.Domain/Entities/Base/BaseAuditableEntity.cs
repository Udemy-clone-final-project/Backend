using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RedBubble.Domain.Entities.Base
{
    public interface IBaseAuditableEntity
    {
        public string CreatedBy { get; set; } // it is not string here , it will be a user prpoperty with id as a foreign key and navigation property ==> a not by shahenda
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; } 
        public DateTime LastModifiedOn { get; set; }
    }

    public abstract class BaseAuditableEntity<TKey> : BaseEntity<TKey>, IBaseAuditableEntity
        where TKey : IEquatable<TKey>
    {
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; } = null!;
        public DateTime LastModifiedOn { get; set; }
    }
}
