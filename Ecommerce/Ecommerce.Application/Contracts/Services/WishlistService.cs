using AutoMapper;
using Ecommerce.Application.Contracts.Interface;
using Ecommerce.Application.DTOs;
using Ecommerce.Application.Repository;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contracts.Services
{
    public class WishlistService : IWishlistService
    {


        private readonly IWishlistRepository _WishlistRepository;
        private readonly IMapper _mapper;

        public WishlistService(IWishlistRepository WishlistRepository, IMapper mapper)
        {
            _WishlistRepository = WishlistRepository;
            _mapper = mapper;
        }

        public async Task AddProductToWishlistAsync(int productId, int userId)
        {
            var catmapModel = _mapper.Map<DTOWishlist>(productId);
            await _WishlistRepository.AddProductToWishlistAsync(productId,userId);
        }

        public async Task<IEnumerable<Wishlist>> GetAllByUserId(int userId)
        {
            return await _WishlistRepository.GetAllByUserId(userId);
        }

        public async Task RemoveProductFromWishlistAsync(int productId, int userId)
        {
            await _WishlistRepository.RemoveProductFromWishlistAsync(productId, userId);
        }

    }
}