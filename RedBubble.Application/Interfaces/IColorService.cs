using RedBubble.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces
{
    public interface IColorService
    {
        Task<List<ColorDto>> GetAllAsync();
        Task<ColorDto> GetByIdAsync(int id);

        Task<int> CreateAsync(CreateColorDto dto);
        Task<bool> UpdateAsync(UpdateColorDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
