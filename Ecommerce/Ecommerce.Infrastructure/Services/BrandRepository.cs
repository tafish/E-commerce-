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
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(DBContextApplication context) : base(context)
        {
        }

        public Task<List<Product>> DispalyProductsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Brand>> GetBrandwithProductsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }
    }
}
