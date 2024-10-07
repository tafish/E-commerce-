using AutoMapper;
using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecommerce.Application.DTOs.DTOvisa;

namespace Ecommerce.Application.Automapper
{
    public class visaProfile : Profile
    {
        public visaProfile()
        {
            CreateMap<DTOvisa, visa>().ReverseMap();
            CreateMap<DTOUpdatevisa, visa>().ReverseMap(); 
        }
    }
}
