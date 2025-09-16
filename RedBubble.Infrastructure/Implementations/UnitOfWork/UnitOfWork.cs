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
    public class UnitOfWork(AppDbContext dbContext) : IUnitOfWork
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

#region Diffence between CompleteAsync() and DisposeAsync()
//CompleteAsync()

//What it does:
//This method commits (saves) all the changes you've made to the tracked entities in your DbContext to the database.

//Use when:
//You want to persist changes like adding, updating, or deleting entities.
//You are at the end of a service method and want to finalize the transaction.

//Returns:
//int → the number of state entries written to the database.

////////////////////////////////////////////////////////////////////////////////////
///
//DisposeAsync()

//What it does:
//This method disposes the DbContext asynchronously — i.e., it releases the database connection and other unmanaged resources.

//Use when:
//You are done using the DbContext.
//You're using await using or IAsyncDisposable for clean and efficient resource management.

//Returns:
//ValueTask → a lightweight struct like Task, used for better performance in some async contexts.
#endregion
