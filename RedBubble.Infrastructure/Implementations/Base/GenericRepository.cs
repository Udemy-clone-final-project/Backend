using Microsoft.EntityFrameworkCore;
using RedBubble.Domain.Entities.Base;
using RedBubble.Domain.Interfaces;
using RedBubble.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
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
        => withTracking ? await _dbContext.Set<TEntity>().ToListAsync() : await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();

        public async Task<TEntity?> GetByIdAsync(TKey id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public void Update(TEntity entity)
        => _dbContext.Set<TEntity>().Update(entity);


    }
}
