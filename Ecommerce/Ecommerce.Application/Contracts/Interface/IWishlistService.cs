using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecommerce.Application.DTOs.DTOAddress;

namespace Ecommerce.Application.Contracts.Interface
{
    public interface IWishlistService
    {
      public Task RemoveProductFromWishlistAsync(int productId, int userId);

      public Task AddProductToWishlistAsync(int productId, int userId);

      public Task<IEnumerable<Wishlist>> GetAllByUserId(int userId);

    }
}
