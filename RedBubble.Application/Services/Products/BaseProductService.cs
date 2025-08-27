using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.Interfaces.Services;
using RedBubble.Domain.Entities.Models.Products;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Services
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

        public async Task<IEnumerable<ProductDto>> GetAllBaseProductsAsync()
        {         
                var repository = _unitOfWork.GetRepository<BaseProduct, int>();
                var products = await repository.GetAll()
                    .Include(p => p.Category)
                    .ToListAsync();
                return _mapper.Map<IEnumerable<ProductDto>>(products);
        }
        public async Task<ProductDto?> GetBaseProductByIdAsync(int id)
        {

                var repository = _unitOfWork.GetRepository<BaseProduct, int>();
                var product = await repository.GetAll()
                    .Include(p => p.Category)
                    .FirstOrDefaultAsync(p => p.Id == id);
                return product != null ? _mapper.Map<ProductDto>(product) : null;
            

        }
        public async Task<ProductDto> CreateBaseProductAsync(CreateProductDto createProductDto, string createdBy)
        {
           

                if (!await IsBaseProductNameUniqueAsync(createProductDto.Name))
                {
                    throw new ArgumentException($"Product with name '{createProductDto.Name}' already exists");
                }

                var product = _mapper.Map<BaseProduct>(createProductDto);
                product.CreatedBy = createdBy;
                product.CreatedOn = DateTime.UtcNow;
                product.LastModifiedBy = createdBy;
                product.LastModifiedOn = DateTime.UtcNow;

                var repository = _unitOfWork.GetRepository<BaseProduct, int>();
                await repository.AddAsync(product);
                await _unitOfWork.CompleteAsync();


                return _mapper.Map<ProductDto>(product);
            

        }

        public async Task<ProductDto?> UpdateBaseProductAsync(UpdateProductDto updateProductDto, string modifiedBy)
        {
            

                var repository = _unitOfWork.GetRepository<BaseProduct, int>();
                var existingProduct = await repository.GetByIdAsync(updateProductDto.Id);

                if (existingProduct == null)
                {
                    return null;
                }

               
                if (!await IsBaseProductNameUniqueAsync(updateProductDto.Name))
                {
                    throw new ArgumentException($"Product with name '{updateProductDto.Name}' already exists");
                }

                _mapper.Map(updateProductDto, existingProduct);
                existingProduct.LastModifiedBy = modifiedBy;
                existingProduct.LastModifiedOn = DateTime.UtcNow;

                repository.Update(existingProduct);
                await _unitOfWork.CompleteAsync();

                return _mapper.Map<ProductDto>(existingProduct);
         
        }

        public async Task<bool> DeleteBaseProductAsync(int id)
        {

                var repository = _unitOfWork.GetRepository<BaseProduct, int>();
                var product = await repository.GetByIdAsync(id);
                if (product == null)
                {
                    return false;
                }
                repository.Delete(product);
                await _unitOfWork.CompleteAsync();
                return true;
        }

 
        public async Task<bool> IsBaseProductNameUniqueAsync(string name)
        {
  
                var repository = _unitOfWork.GetRepository<BaseProduct, int>();
                var query = repository.GetAll().Where(p => p.Name == name);
                return !await query.AnyAsync();
        }

      

      
    }
}