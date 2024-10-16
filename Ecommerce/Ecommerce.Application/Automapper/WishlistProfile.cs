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
    public class WishlistProfile : Profile
    {

        public WishlistProfile()
        {
            CreateMap<DTOWishlist, Wishlist>().ReverseMap();

        }
    
    }
}
