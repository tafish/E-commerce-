using Ecommerce.Application.Repository;
using Ecommerce.Domain;
using Ecommerce.Infrastructure.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Services
{
    public class WishlistRepository : Repository<Wishlist>, IWishlistRepository
    {
        public WishlistRepository(DBContextApplication context) : base(context)
        {
        }

        public Task AddProductToWishlistAsync(int productId, int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Wishlist>> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveProductFromWishlistAsync(int productId, int userId)
        {
            throw new NotImplementedException();
        }


    }
}
