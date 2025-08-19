using AutoMapper;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.Interfaces.Products;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Services.Products
{
    public class BaseProductService : IBaseProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BaseProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseProductDto> CreateBaseProductAsync(CreateBaseProductDto dto)
        {
            var categoryRepository = _unitOfWork.GetRepository<Category, int>();
            var categoryExists = await categoryRepository.GetByIdAsync(dto.CategoryId);
            if (categoryExists == null)
            {
               
                throw new KeyNotFoundException($"Category with ID {dto.CategoryId} was not found.");
            }

           
            var productEntity = _mapper.Map<BaseProduct>(dto);

           
            var productRepository = _unitOfWork.GetRepository<BaseProduct, int>();
            await productRepository.AddAsync(productEntity);
            await _unitOfWork.CompleteAsync();

         
            return _mapper.Map<BaseProductDto>(productEntity);
        }

        public async Task<IEnumerable<BaseProductDto>> GetAllBaseProductsAsync()
        {
            var productRepository = _unitOfWork.GetRepository<BaseProduct, int>();
           
            var products = await productRepository.GetAllAsync(); 
            return _mapper.Map<IEnumerable<BaseProductDto>>(products);
        }

        public async Task<BaseProductDto?> GetBaseProductByIdAsync(int id)
        {
            var productRepository = _unitOfWork.GetRepository<BaseProduct, int>();
            var product = await productRepository.GetByIdAsync(id);


            return _mapper.Map<BaseProductDto?>(product);
        }

        public async Task<bool> UpdateBaseProductAsync(int id, CreateBaseProductDto dto)
        {
            var productRepository = _unitOfWork.GetRepository<BaseProduct, int>();
            var existingProduct = await productRepository.GetByIdAsync(id);

            if (existingProduct == null)
            {
                return false; 
            }

            _mapper.Map(dto, existingProduct);

            productRepository.Update(existingProduct);
            await _unitOfWork.CompleteAsync();

            return true;
        }

        public async Task<bool> DeleteBaseProductAsync(int id)
        {
            var productRepository = _unitOfWork.GetRepository<BaseProduct, int>();
            var productToDelete = await productRepository.GetByIdAsync(id);

            if (productToDelete == null)
            {
                return false; 
            }

            productRepository.Delete(productToDelete);
            await _unitOfWork.CompleteAsync();

            return true;
        }
    }
}
