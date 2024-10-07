using AutoMapper;
using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecommerce.Application.DTOs.DTOAddress;

namespace Ecommerce.Application.Automapper
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {

            CreateMap<DTOAddress, Address>().ReverseMap();
            CreateMap<DTOUpdateAddress, Address>().ReverseMap();
        }
    }
}
