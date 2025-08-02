using RedBubble.Application.DTOs;
using RedBubble.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Services
{
    public class ColorService : IColorService
    {
        public Task<int> CreateAsync(CreateColorDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ColorDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ColorDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(UpdateColorDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
