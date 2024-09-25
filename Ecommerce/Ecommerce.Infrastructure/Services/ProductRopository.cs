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
    public class ProductRopository : Repository<Product>, IProductRopository
    {
        public ProductRopository(DBContextApplication context) : base(context)
        {
        }

        public Task<Product> AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IRepository<Product>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Product> IRepository<Product>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
