using AutoMapper;
using RedBubble.Application.DTOs;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Interfaces;

namespace RedBubble.Infrastructure.Implementations.Services
{
    public class ColorService : IColorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ColorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ColorDto>> GetAllAsync()
        {
            var repo = _unitOfWork.GetRepository<Color, int>();
            var colors = await repo.GetAllAsync();
            return _mapper.Map<List<ColorDto>>(colors);
        }

        public async Task<ColorDto> GetByIdAsync(int id)
        {
            var repo = _unitOfWork.GetRepository<Color, int>();
            var color = await repo.GetByIdAsync(id);
            if (color == null)
                throw new KeyNotFoundException($"Color with Id {id} not found.");

            return _mapper.Map<ColorDto>(color);
        }

        public async Task<int> CreateAsync(CreateColorDto dto)
        {
            var repo = _unitOfWork.GetRepository<Color, int>();
            var entity = _mapper.Map<Color>(dto);

            await repo.AddAsync(entity);
            await _unitOfWork.CompleteAsync();

            return entity.Id; 
        }

        public async Task<bool> UpdateAsync(UpdateColorDto dto)
        {
            var repo = _unitOfWork.GetRepository<Color, int>();
            var entity = await repo.GetByIdAsync(dto.Id);

            if (entity == null)
                return false;

            _mapper.Map(dto, entity);
            repo.Update(entity);

            await _unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var repo = _unitOfWork.GetRepository<Color, int>();
            var entity = await repo.GetByIdAsync(id);

            if (entity == null)
                return false;

            repo.Delete(entity);
            await _unitOfWork.CompleteAsync();

            return true;
        }
    }
}
