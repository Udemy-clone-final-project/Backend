using RedBubble.Application.DTOs.Design;
using RedBubble.Application.Services;
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
        Task<PagedList<DesignDto>> GetAllAsync(string? searchItem, string? sortColumn, string? sortOrder,
           int page, int pageSize);

        Task<DesignDto> GetDesignByIdAsync(int id);

        Task<DesignDto> CreateAsync(CreateDesignDto createDesignDto);

       Task<DesignDto> Update(UpdateDesignDto updateDesignDto);
        Task<bool> DeleteDesignAsync(int id);
        



    }
}
