using Ecommerce.Application.Repository;
using Ecommerce.Domain;
using Ecommerce.Infrastructure.Presistance;
using Microsoft.AspNetCore.Http;

namespace Ecommerce.Infrastructure.Services
{
    public class ProductRopository : Repository<Product>, IProductRopository, IImageRepository<Product>, IRelatedProductRepository
    {
        public ProductRopository(DBContextApplication context) : base(context)
        {

        }

        public Task AddBrandToProduct(int productId, int brandId)
        {
            throw new NotImplementedException();
        }

        public Task AddCategoryToProduct(int productId, int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task addNewImage<T>(int id, IFormFile formFile)
        {
            throw new NotImplementedException();
        }

        public Task deleteImage<T>(int imgId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> DispalyProductsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
