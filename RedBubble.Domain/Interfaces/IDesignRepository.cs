using RedBubble.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Interfaces
{
    public interface IDesignRepository : IGenericRepository<Design, Guid>
    {
        public IQueryable<Design> GetAllByArtist(Guid artistId);
         Task<Design> GetByNameAsync(string name);

        
    }
}
