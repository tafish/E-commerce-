using AutoMapper;
using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecommerce.Application.DTOs.DTOBrand;

namespace Ecommerce.Application.Automapper
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
           
                CreateMap<DTOBrand, Brand>();
                CreateMap<DTOUpdateBrand, Brand>();

           
        }
    }
}
