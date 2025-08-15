using AutoMapper;
using RedBubble.Application.DTOs.Design;
using RedBubble.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBubble.Application.Mappers
{
    public class DesignProfile : Profile
    {
        public DesignProfile()
        {
            // convert from ArtistDesignDTO to Design
            CreateMap<ArtistDesignDTO, Design>()
            .ForMember(dest => dest.Id, opt => opt.Ignore()) // id is generated
            .ForMember(dest => dest.ArtistId, opt => opt.Ignore())
            .ForMember(dest => dest.Artist, opt => opt.Ignore())
            .ForMember(dest => dest.AdminId, opt => opt.Ignore())
            .ForMember(dest => dest.Admin, opt => opt.Ignore())
            .ForMember(dest => dest.UploadedAt, opt => opt.Ignore())
            .ForMember(dest => dest.Status, opt => opt.Ignore())
            .ForMember(dest => dest.IsActive, opt => opt.Ignore())
            .ForMember(dest => dest.ReviewedAt, opt => opt.Ignore())
            .ForMember(dest => dest.RejectionReason, opt => opt.Ignore());

            // convert from Design to ArtistDesignDTO
            CreateMap<Design, ArtistDesignDTO>();

            // convert from Design to ArtistGetDesignDTO
            CreateMap<Design, ArtistGetDesignDTO>();


        }
    }
}
