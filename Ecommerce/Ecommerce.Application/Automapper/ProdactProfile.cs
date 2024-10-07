using AutoMapper;
using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Automapper
{
    public class ProdactProfile : Profile

    {
        public ProdactProfile()
        {
           
       
            CreateMap<DTOProduct, Product>().ReverseMap();
            CreateMap<DTOUpdetProduct, Product>().ReverseMap();
        }
    }
}
