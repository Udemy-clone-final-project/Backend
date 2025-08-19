using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RedBubble.Domain.Entities.Base;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Interfaces;
using RedBubble.Infrastructure.DataAccess;
using RedBubble.Infrastructure.Implementations.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.Implementations.Base
{
    public class GenericRepository<TEntity, TKey>(AppDbContext _dbContext) : IGenericRepository<TEntity, TKey>
      where TEntity : BaseEntity<TKey>
      where TKey : IEquatable<TKey>

    {
        public async Task AddAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

            
        public async Task<IEnumerable<TEntity>> GetAllAsync(bool withTracking = false)
             => withTracking 
            ? await _dbContext.Set<TEntity>().ToListAsync()  // EF Core will track the results.
            : await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync(); // EF Core won’t track the results.

        public IQueryable<TEntity> GetAll() => _dbContext.Set<TEntity>();
        public async Task<TEntity?> GetByIdAsync(TKey id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public void Update(TEntity entity)
        => _dbContext.Set<TEntity>().Update(entity);

    }
}

// notes on GetAllAsync 
// Parameter: bool withTracking = false
// Optional parameter:
// If true: EF Core will track the retrieved entities.
// If false: EF Core will not track them(better for read-only operations).
// What is tracking?
// EF Core by default tracks changes to entities so it can later generate UPDATE, DELETE, etc.
// Useful when you plan to modify and save entities.
// But it adds memory overhead if you're just reading data.

#region notes on SaveChanges & Unit Of Work 
// why methods on context =>  create update delete but without save changes on the db ?
// the methods like AddAsync, Delete, Update do not call _dbContext.SaveChanges() directly — and that's intentional. Here's why:
// Design Pattern Used: Unit of Work (UoW)
// This approach follows the Unit of Work pattern, where:
// The repository is responsible for preparing data operations (add/update/delete),
// But the actual saving of those changes is deferred to the UnitOfWork.Commit() or SaveChangesAsync() method.

// Why this is useful:
// You can perform multiple operations (e.g., add a design, update a product, delete a user) in a single transaction, and then commit all of them together.
// It improves testability, flexibility, and performance.
// You avoid calling SaveChanges() too early or too often.

//Layer Responsibility
//Repository => Prepares CRUD operations (but does not save)
//Unit of Work =>	Commits all prepared changes in one transaction
//Service Layer	=> Coordinates multiple operations via UoW

//Example without UnitOfWork:

//productRepo.Add(product);
//await _dbContext.SaveChangesAsync(); // saves immediately

//orderRepo.Add(order);
//await _dbContext.SaveChangesAsync(); // saves again separately

//With UnitOfWork:

//productRepo.Add(product);
//orderRepo.Add(order);
//await unitOfWork.SaveChangesAsync(); // saves both together
#endregion