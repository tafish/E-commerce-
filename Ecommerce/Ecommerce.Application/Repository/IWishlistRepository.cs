using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Repository
{
    public interface IWishlistRepository 
    {
        Task AddProductToWishlistAsync(int productId, int userId);
        Task RemoveProductFromWishlistAsync(int productId, int userId);
        Task<IEnumerable<Wishlist>> GetAllByUserId(int userId);
    }
}
