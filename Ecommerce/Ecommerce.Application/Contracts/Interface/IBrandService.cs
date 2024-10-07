using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecommerce.Application.DTOs.DTOAddress;
using static Ecommerce.Application.DTOs.DTOBrand;

namespace Ecommerce.Application.Contracts.Interface
{
    public interface IBrandService
    {
        public Task<IEnumerable<Brand>> GetAllBrand();

        public Task<Brand> GetBrandById(int id);

        public Task CreateBrand(DTOBrand DTOBrand);

        public Task UpdateBrand(DTOUpdateBrand Brand);

        public Task DeleteBrand(int id);
    }
}
