using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Entities.Base
{
    public interface IBaseEntity<TKey> where TKey : IEquatable<TKey>
    {
        TKey? Id { get; set; }
    }

    public abstract class BaseEntity<TKey> : IBaseEntity<TKey>
         where TKey : IEquatable<TKey>
    {
        public TKey? Id { get; set; }
    }
}
