using AutoMapper;
using RedBubble.Application.Interfaces;
using RedBubble.Application.Interfaces.Products;
using RedBubble.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Services
{
    internal class ServiceManager : IServiceManager
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly Lazy<IBaseProductService> _baseProductService;
        public ServiceManager(IUnitOfWork unitOfWork, IMapper mapper, Lazy<IBaseProductService> baseProductService)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            _baseProductService = baseProductService;
           
        }

        public IBaseProductService baseProductService => _baseProductService.Value;


    }
}