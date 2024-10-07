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
    public class BrandServicecs : IBrandService
    {


        private readonly IBrandRepository _BrandRepository;
        private readonly IMapper _mapper;

        public BrandServicecs(IBrandRepository BrandRepository, IMapper mapper)
        {
            _BrandRepository = BrandRepository;
            _mapper = mapper;
        }
        public async Task CreateBrand(DTOBrand DTOBrand)
        {

            var catmapModel = _mapper.Map<Brand>(DTOBrand);
            await _BrandRepository.AddAsync(catmapModel);
        }

        public async Task DeleteBrand(int id)
        {
            await _BrandRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Brand>> GetAllBrand()
        {
            return await _BrandRepository.GetAllAsync();
        }

        public async Task<Brand> GetBrandById(int id)
        {
            return await _BrandRepository.GetByIdAsync(id);
        }

        public async Task UpdateBrand(DTOBrand.DTOUpdateBrand Brand)
        {
            var catmapModel = _mapper.Map<Brand>(Brand);
            await _BrandRepository.UpdateAsync(catmapModel);
        }
    }
}
