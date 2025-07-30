﻿using Final.Domain.Common;
using Final.Infrastructure.Persistence._Data;
using LinkDev.Talabat.Core.Domain.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Infrastructure.Persistence.Generic_Repository
{
    internal class GenericRepository<TEntity, TKey>(FinalDbContext _dbContext) : IGenericRepository<TEntity, TKey>
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
