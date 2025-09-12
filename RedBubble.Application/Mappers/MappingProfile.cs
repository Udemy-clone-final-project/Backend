using AutoMapper;
using RedBubble.Application.DTOs;
using RedBubble.Application.DTOs.Cart;
using RedBubble.Application.DTOs.Products;
using RedBubble.Application.DTOs.Products.ProductVariant;
using RedBubble.Application.DTOs.Products.ProductVariant.ProductVariantImage;
using RedBubble.Domain.Entities.Models;
using RedBubble.Domain.Entities.Models.Cart;
using RedBubble.Domain.Entities.Models.Products;

namespace RedBubble.Application.Mappers
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // BaseProduct

            // Add these mappings to your existing MappingProfile.cs

            // BaseProduct mappings
            CreateMap<BaseProduct, BaseProductDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category!.CategoryName));

            CreateMap<BaseProduct, BaseProductListDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category!.CategoryName))
                .ForMember(dest => dest.PrimaryMockupUrl, opt => opt.MapFrom(src =>
                    src.Templates.Where(t => t.IsActive && t.IsPrimary)
                                 .Select(t => t.MockupUrl)
                                 .FirstOrDefault() ?? string.Empty))
                .ForMember(dest => dest.VariantsCount, opt => opt.MapFrom(src => src.ProductVariants.Count(v => v.IsActive)));

            CreateMap<CreateBaseProductDto, BaseProduct>();
            CreateMap<UpdateBaseProductDto, BaseProduct>();

            // Print Area mappings
            CreateMap<BaseProductPrintArea, PrintAreaDto>();
            CreateMap<CreatePrintAreaDto, BaseProductPrintArea>()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => true));
            CreateMap<UpdatePrintAreaDto, BaseProductPrintArea>();

            // Template mappings
            CreateMap<BaseProductTemplate, TemplateDto>();
            CreateMap<CreateTemplateDto, BaseProductTemplate>()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => true));
            CreateMap<UpdateTemplateDto, BaseProductTemplate>();

            // Junction table mappings
            CreateMap<BaseProductSize, BaseProductSizeDto>()
                .ForMember(dest => dest.SizeName, opt => opt.MapFrom(src => src.Size!.SizeName))
                .ForMember(dest => dest.SizeDescription, opt => opt.MapFrom(src => src.Size!.Description));

            CreateMap<BaseProductColor, BaseProductColorDto>()
                .ForMember(dest => dest.ColorName, opt => opt.MapFrom(src => src.Color!.ColorName))
                .ForMember(dest => dest.ColorCode, opt => opt.MapFrom(src => src.Color!.ColorCode));

            // User mappings
            //CreateMap<ApplicationUser, UserDTO>();
            //CreateMap<AccountCreateDTO, ApplicationUser>()
            //    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => true))
            //    .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
            //    .ForMember(dest => dest.LastModifiedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
            //    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName ?? src.Email));
            //CreateMap<AccountUpdateDTO, ApplicationUser>()
            //.ForMember(dest => dest.LastModifiedOn, opt => opt.MapFrom(src => DateTime.UtcNow));
            //CreateMap<ApplicationUser, LoginResponseDTO>();

            //// Role mappings
            //CreateMap<ApplicationRole, RoleDTO>()
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            //CreateMap<RoleDTO, ApplicationRole>()

            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));


            //size
            CreateMap<Size, SizeDto>();
            CreateMap<CreateSizeDto, Size>();
            CreateMap<UpdateSizeDto, Size>();
         


            //color
            CreateMap<Color, ColorDto>();
            CreateMap<CreateColorDto, Color>();
            CreateMap<UpdateColorDto, Color>();
            CreateMap<Color, UpdateColorDto>();



            //ProductVariant

            CreateMap<ProductVariant, ProductVariantDto>()
                 .ForMember(dest => dest.BaseProductName, opt => opt.MapFrom(src => src.BaseProduct!.Name))
                 .ForMember(dest => dest.BaseProductPrice, opt => opt.MapFrom(src => src.BaseProduct!.BasePrice))
                 .ForMember(dest => dest.DesignTitle, opt => opt.MapFrom(src => src.Design!.Title))
                 .ForMember(dest => dest.DesignPrice, opt => opt.MapFrom(src => src.Design!.Price))
                 .ForMember(dest => dest.ColorName, opt => opt.MapFrom(src => src.Color!.ColorName))
                 .ForMember(dest => dest.ColorCode, opt => opt.MapFrom(src => src.Color!.ColorCode))
                 .ForMember(dest => dest.SizeName, opt => opt.MapFrom(src => src.Size!.SizeName))
                 .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.ProductVariantImages));
            CreateMap<CreateProductVariantDto, ProductVariant>();
            CreateMap<UpdateProductVariantDto, ProductVariant>();
            CreateMap<ProductVariantImages, ProductVariantImageDto>();
            CreateMap<CreateProductVariantImageDto, ProductVariantImages>();


            //Category
            CreateMap<Category, CategoryDto>()
             .ForMember(dest => dest.ParentCategoryName, opt => opt.MapFrom(src => src.ParentCategory != null ? src.ParentCategory.CategoryName : null))
             .ForMember(dest => dest.IsMainCategory, opt => opt.MapFrom(src => src.ParentCategoryId == null))
             .ForMember(dest => dest.IsSubCategory, opt => opt.MapFrom(src => src.ParentCategoryId != null));

            CreateMap<Category, CategoryWithSubCategoriesDto>()
                .ForMember(dest => dest.SubCategories, opt => opt.MapFrom(src => src.SubCategories))
                .ForMember(dest => dest.IsMainCategory, opt => opt.MapFrom(src => src.ParentCategoryId == null));

            CreateMap<CreateCategoryDto, Category>()
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => "System"));
              

            CreateMap<UpdateCategoryDto, Category>()
                .ForMember(dest => dest.LastModifiedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.LastModifiedBy, opt => opt.MapFrom(src => "System")); 
            CreateMap<Category, UpdateCategoryDto>();

            //////////////Cart Mappings////////////////
            CreateMap<CartItem, CartItemDto>().ReverseMap();
            CreateMap<CustomerCart, CustomerCartDto>().ReverseMap();




        }
    }
}
