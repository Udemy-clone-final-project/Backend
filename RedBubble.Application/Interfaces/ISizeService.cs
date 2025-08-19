using RedBubble.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedBubble.Application.Interfaces
{
    public interface ISizeService
    {
        Task<IEnumerable<SizeDto>> GetAllSizesAsync();
        Task<SizeDto?> GetSizeByIdAsync(int id);
        Task<SizeDto> CreateSizeAsync(CreateSizeDto createSizeDto);
        Task<SizeDto> UpdateSizeAsync(UpdateSizeDto updateSizeDto);
        Task DeleteSizeAsync(int id);
    }
}