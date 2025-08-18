using RedBubble.Application.DTOs.Design;
using RedBubble.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces
{
    public interface IDesignService
    {
        Task CreateAsync(ArtistDesignDTO artistDesignDTO , Guid artistId);
        Task<IEnumerable<ArtistGetDesignDTO>> GetAllAsync(Guid artistId);

        Task Update(ArtistDesignDTO artistDesignDTO, int designId);

        //Task<Design> GetByIdAsync(int id);  // design dto 
        //Task<Design> GetByNameAsync(string name); // design dto 



        //Task DeleteAsync(int id);

        //Task UpdateAsync(int id, Design design);// design dto 



    }
}
