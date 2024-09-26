using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contracts.Interface
{
    public interface IProductServicecs
    {
        public Task<IEnumerable<Product>> GetAllProduct();

        public Task<Product> GetProductById(int id);

        public Task CreateProduct(DTOProduct DTOProduct);

        public Task UpdateProduct(DTOProduct Product);

        public Task DeleteProduct(int id);
    }
}
