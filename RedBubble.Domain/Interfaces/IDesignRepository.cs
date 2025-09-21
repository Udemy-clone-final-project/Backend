using RedBubble.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Domain.Interfaces
{
    public interface IDesignRepository : IGenericRepository<Design, int>
    {
        public IQueryable<Design> GetAllByArtist(string artistId);
         Task<Design> GetByNameAsync(string name);

        
    }
}
