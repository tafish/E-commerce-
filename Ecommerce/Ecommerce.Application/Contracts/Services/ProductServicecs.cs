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
    public class ProductServicecs : IProductServicecs
    {
        private readonly IProductRopository _ProductRopository;
        private readonly IMapper _mapper;

        public ProductServicecs(IProductRopository ProductRopository, IMapper mapper)
        {
            _ProductRopository = ProductRopository;
            _mapper = mapper;
        }
        public async Task CreateProduct(DTOProduct DTOProduct)
        {
            var catmapModel = _mapper.Map<Product>(DTOProduct);
            await _ProductRopository.AddAsync(catmapModel);
        }  

        public async Task DeleteProduct(int id)
        {
            await _ProductRopository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            return await _ProductRopository.GetAllAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _ProductRopository.GetByIdAsync(id);
        }

        public async Task UpdateProduct(DTOProduct Product)
        {
            var catmapModel = _mapper.Map<Product>(Product);
            await _ProductRopository.UpdateAsync(catmapModel);
        }
    }
}
