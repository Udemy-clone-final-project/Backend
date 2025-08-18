using AutoMapper;
using RedBubble.Application.DTOs;
using RedBubble.Application.Interfaces;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedBubble.Application.Services
{
    public class SizeService : ISizeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SizeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SizeDto>> GetAllSizesAsync()
        {
            var sizes = await _unitOfWork.GetRepository<Size, int>().GetAllAsync();
            return _mapper.Map<IEnumerable<SizeDto>>(sizes);
        }

        public async Task<SizeDto?> GetSizeByIdAsync(int id)
        {
            var size = await _unitOfWork.GetRepository<Size, int>().GetByIdAsync(id);
            return _mapper.Map<SizeDto>(size);
        }

        public async Task<SizeDto> CreateSizeAsync(CreateSizeDto createSizeDto)
        {
            var size = _mapper.Map<Size>(createSizeDto);
            await _unitOfWork.GetRepository<Size, int>().AddAsync(size);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<SizeDto>(size);
        }

        public async Task<SizeDto> UpdateSizeAsync(UpdateSizeDto updateSizeDto)
        {
            var size = await _unitOfWork.GetRepository<Size, int>().GetByIdAsync(updateSizeDto.Id);
            if (size == null)
            {
                throw new KeyNotFoundException($"Size with ID {updateSizeDto.Id} not found.");
            }

            _mapper.Map(updateSizeDto, size);
            _unitOfWork.GetRepository<Size, int>().Update(size);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<SizeDto>(size);
        }

        public async Task DeleteSizeAsync(int id)
        {
            var size = await _unitOfWork.GetRepository<Size, int>().GetByIdAsync(id);
            if (size == null)
            {
                throw new KeyNotFoundException($"Size with ID {id} not found.");
            }

            _unitOfWork.GetRepository<Size, int>().Delete(size);
            await _unitOfWork.CompleteAsync();
        }
    }
}