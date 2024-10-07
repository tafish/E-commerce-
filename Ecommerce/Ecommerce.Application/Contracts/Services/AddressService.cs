using AutoMapper;
using Ecommerce.Application.Contracts.Interface;
using Ecommerce.Application.DTOs;
using Ecommerce.Application.Repository;
using Ecommerce.Domain;

namespace Ecommerce.Application.Contracts.Services
{
    public class AddressService : IAddressService
    {

        private readonly IAddressRepository _AddressRepository;
        private readonly IMapper _mapper;

        public AddressService(IAddressRepository AddressRepository, IMapper mapper)
        {
            _AddressRepository = AddressRepository;
            _mapper = mapper;
        }
        public async Task CreateAddress(DTOAddress DTOAddress)
        {
            var catmapModel = _mapper.Map<Address>(DTOAddress);
            await _AddressRepository.AddAsync(catmapModel);
        }

        public async Task DeleteAddress(int id)
        {
            await _AddressRepository.DeleteAsync(id);
        }

        public async Task<Address> GetAddressById(int id)
        {
            return await _AddressRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Address>> GetAllAddress()
        {
            return await _AddressRepository.GetAllAsync();
        }

        public async Task UpdateAddress(DTOAddress.DTOUpdateAddress address)
        {
            var catmapModel = _mapper.Map<Address>(address);
            await _AddressRepository.UpdateAsync(catmapModel);
        }
    }
}