using RedBubble.Domain.Entities.Base;
using RedBubble.Domain.Interfaces;
using RedBubble.Infrastructure.Data;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.Implementations.Base
{
    internal class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
    {
        private readonly ConcurrentDictionary<string, object> _repositories = new();

        public IGenericRepository<TEntity, TKey> GetRepository<TEntity, TKey>()
            where TEntity : BaseEntity<TKey>
            where TKey : IEquatable<TKey>
        {
            // return new GenericRepository<TEntity, TKey>(dbContext);

            /// var typeName = typeof(TEntity).Name;
            /// if(_repositories.ContainsKey(typeName)) return (IGenericRepository<TEntity, TKey>) _repositories[typeName];
            /// 
            /// var repository = new GenericRepository<TEntity, TKey>(dbContext);
            /// 
            /// _repositories.Add(typeName, repository);
            /// 
            /// return repository;

            return (IGenericRepository<TEntity, TKey>)_repositories.GetOrAdd(typeof(TEntity).Name, new GenericRepository<TEntity, TKey>(dbContext));
        }


        public async Task<int> CompleteAsync() => await dbContext.SaveChangesAsync();

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();

    }
}
