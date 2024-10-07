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
    public class VisaService : IVisaService
    {
        private readonly IVisaRepository _VisaRepository;
        private readonly IMapper _mapper;

        public VisaService(IVisaRepository VisaRepository, IMapper mapper)
        {
            _VisaRepository = VisaRepository;
            _mapper = mapper;
        }

        public async Task CreateVisa(DTOvisa DTOvisa)
        {
            var catmapModel = _mapper.Map<visa>(DTOvisa);
            await _VisaRepository.AddAsync(catmapModel);
        }

        public async Task DeleteVisa(int id)
        {
            await _VisaRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<visa>> GetAllVisa()
        {
            return await _VisaRepository.GetAllAsync();
        }

        public async Task<visa> GetVisaById(int id)
        {
            return await _VisaRepository.GetByIdAsync(id);
        }

        public async Task UpdateVisa(DTOvisa.DTOUpdatevisa visa)
        {
            var catmapModel = _mapper.Map<visa>(visa);
            await _VisaRepository.UpdateAsync(catmapModel);
        }
    }
}
