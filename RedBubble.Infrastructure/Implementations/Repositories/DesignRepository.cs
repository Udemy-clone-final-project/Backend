using Microsoft.EntityFrameworkCore;
using RedBubble.Application.DTOs.Design;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Interfaces;
using RedBubble.Infrastructure.DataAccess;
using RedBubble.Infrastructure.Implementations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Infrastructure.Implementations.Repositories
{
    // Inherits from your generic base class GenericRepository<Design, Guid>
    // Implements the IDesignRepository interface
    // Passes AppDbContext to the base class (GenericRepository) constructor
    public class DesignRepository(AppDbContext context) : GenericRepository<Design, int>(context), IDesignRepository
    {
        // GetAllAsync()
        // _dbset.Designs.GetAllAsync().Tolist();

        public IQueryable<Design> GetAllByArtist(Guid artistId)
        {
            return context.Designs.
                Where(d => d.ArtistId == artistId);
        }
        public async Task<Design> GetByNameAsync(string name)
        {
            return await context.Designs.FirstOrDefaultAsync(d => d.Title == name);
        }
    }
}
