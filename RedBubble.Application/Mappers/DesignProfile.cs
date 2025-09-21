using AutoMapper;
using RedBubble.Application.DTOs.Design;
using RedBubble.Application.DTOs.Design.DesignImages;
using RedBubble.Domain.Entities.Models;

namespace RedBubble.Application.Profiles
{
    public class DesignProfile : Profile
    {
        public DesignProfile()
        {
            CreateMap<Design, DesignDto>()
                .ForMember(dest => dest.AdminName, opt => opt.MapFrom(src => src.Admin != null ? src.Admin.DisplayName : string.Empty))
                .ForMember(dest => dest.ProductVariants, opt => opt.MapFrom(src => src.ProductVariants));

            CreateMap<DesignDto, Design>();

            CreateMap<CreateDesignDto, Design>()
              
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.AdminId ?? "System"))
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.LastModifiedBy, opt => opt.MapFrom(src => src.AdminId ?? "System"))
                .ForMember(dest => dest.LastModifiedOn, opt => opt.MapFrom(src => DateTime.UtcNow));

            CreateMap<UpdateDesignDto, Design>()
                .ForMember(dest => dest.LastModifiedBy, opt => opt.MapFrom(src => src.AdminId ?? "System"))
                .ForMember(dest => dest.LastModifiedOn, opt => opt.MapFrom(src => DateTime.UtcNow));
        }
    }
}