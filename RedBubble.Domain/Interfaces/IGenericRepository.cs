using RedBubble.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Interfaces
{
    public interface IGenericRepository<TEntity, TKey> 
    where TEntity : BaseEntity<TKey>  // The entity must inherit from BaseEntity<TKey>. This ensures that all entities share common fields like Id, CreatedAt, etc.
    where TKey : IEquatable<TKey> // The key type (e.g., Guid, int) must support equality comparison.
    {
        Task<IEnumerable<TEntity>> GetAllAsync(bool withTracking = false);
        Task<TEntity?> GetByIdAsync(TKey id);
        Task AddAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}
