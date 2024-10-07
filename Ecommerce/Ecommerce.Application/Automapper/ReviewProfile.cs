using AutoMapper;
using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecommerce.Application.DTOs.DTOReview;

namespace Ecommerce.Application.Automapper
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<DTOReview, Review>();
            CreateMap<DTOUpdateReview, Review>();
        }
    }
}
