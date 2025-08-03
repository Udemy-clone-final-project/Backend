using RedBubble.Domain.Entities.Base;
using RedBubble.Domain.Interfaces;
using RedBubble.Infrastructure.DataAccess;
using RedBubble.Infrastructure.Implementations.Base;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.Implementations.UnitOfWork
{
    internal class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
    {
        private readonly ConcurrentDictionary<string, object> repositories = new();
        public async Task<int> CompleteAsync() => await dbContext.SaveChangesAsync();

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();


        public IGenericRepository<TEntity, TKey> GetRepository<TEntity, TKey>()
            where TEntity : BaseEntity<TKey>
            where TKey : IEquatable<TKey>
        {
            //var typename = typeof(TEntity).Name;
            //if (repositories.ContainsKey(typename))
            //    return (IGenericRepository<TEntity, TKey>)repositories[typename];
            //var repo=new GenericRepository<TEntity, TKey>(dbContext);
            //repositories.TryAdd(typename, repo);
            //return repo;

            return (IGenericRepository<TEntity, TKey>)repositories.GetOrAdd(typeof(TEntity).Name, _ => new GenericRepository<TEntity, TKey>(dbContext));

        }
    }
}
