using AutoMapper;
using Ecommerce.Application.DTOs;
using Ecommerce.Application.Repository;
using Ecommerce.Domain;


namespace Ecommerce.Application.Automapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile() 
        {
            CreateMap<DTOCategory, Category>()
            .ForMember(dest => dest.Id, opt=> opt.MapFrom(src => src.Name));

            CreateMap<DTOUpdateCategory, Category>().ReverseMap();
            CreateMap<DTOProduct, Product>().ReverseMap();

        }
    }
}
