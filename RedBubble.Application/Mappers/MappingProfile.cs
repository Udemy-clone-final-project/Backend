using AutoMapper;
using RedBubble.Application.DTOs;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.DTOs.Products.ProductVariant;
using RedBubble.Application.DTOs.Products.ProductVariant.ProductVariantImage;
using RedBubble.Application.DTOs.User;
using RedBubble.Domain.Entities.Models;
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
            CreateMap<BaseProduct, BaseProductDto>().ForMember(dest => dest.CategoryName,
                opt => opt.MapFrom(src => src.Category != null ? src.Category.CategoryName : null));
            CreateMap<CreateBaseProductDto, BaseProduct>();

            // User mappings
            CreateMap<ApplicationUser, UserDTO>();
            CreateMap<AccountCreateDTO, ApplicationUser>()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => true))
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.LastModifiedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName ?? src.Email));
            CreateMap<AccountUpdateDTO, ApplicationUser>()
            .ForMember(dest => dest.LastModifiedOn, opt => opt.MapFrom(src => DateTime.UtcNow));
            CreateMap<ApplicationUser, LoginResponseDTO>();

            // Role mappings
            CreateMap<ApplicationRole, RoleDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            CreateMap<RoleDTO, ApplicationRole>()

                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
            

            // ProductVariant mappings
            CreateMap<ProductVariant, ProductVariantDto>()
                .ForMember(dest => dest.BaseProductName, opt => opt.MapFrom(src => src.BaseProduct != null ? src.BaseProduct.Name : null))
                .ForMember(dest => dest.DesignName, opt => opt.MapFrom(src => src.Design != null ? src.Design.DesignName : null))
                .ForMember(dest => dest.ColorName, opt => opt.MapFrom(src => src.Color != null ? src.Color.ColorName : null))
                .ForMember(dest => dest.SizeName, opt => opt.MapFrom(src => src.Size != null ? src.Size.SizeName : null))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.ProductVariantImages));

            CreateMap<CreateProductVariantDto, ProductVariant>();


            // ProductVariantImages mappings
            CreateMap<ProductVariantImages, ProductVariantImageDto>();

            CreateMap<CreateProductVariantImageDto, ProductVariantImages>();
    
        }
    }
}
