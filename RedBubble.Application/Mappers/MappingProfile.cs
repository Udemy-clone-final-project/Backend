using AutoMapper;
using RedBubble.Application.DTOs.Products;
using RedBubble.Domain.Entities.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Mappers
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BaseProduct,BaseProductDto>().ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category!=null?src.Category.CategoryName:null));
            CreateMap<CreateBaseProductDto, BaseProduct>();
        }
    }
}
