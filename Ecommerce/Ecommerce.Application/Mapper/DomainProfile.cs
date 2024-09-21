using AutoMapper;
using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denizey.BL.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<DTOCategory, Category>().ReverseMap();

        }
    }
}
