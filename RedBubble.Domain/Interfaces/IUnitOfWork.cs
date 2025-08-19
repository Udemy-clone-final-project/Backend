using RedBubble.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Interfaces
{
    // Summary: UnitOfWork in One Line
    // It groups one or more operations (across repositories) into a single transaction,
    // provides a central way to access repositories,
    // and manages database context lifetime.
    public interface IUnitOfWork : IAsyncDisposable
    {
        IGenericRepository<TEntity, TKey> GetRepository<TEntity, TKey>()
            where TEntity : BaseEntity<TKey>
            where TKey : IEquatable<TKey>;

        Task<int> CompleteAsync();

    }
}
