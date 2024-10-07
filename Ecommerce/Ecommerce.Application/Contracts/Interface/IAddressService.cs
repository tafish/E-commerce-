using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecommerce.Application.DTOs.DTOAddress;

namespace Ecommerce.Application.Contracts.Interface
{
    public interface IAddressService
    {
        public Task<IEnumerable<Address>> GetAllAddress();

        public Task<Address> GetAddressById(int id);

        public Task CreateAddress(DTOAddress DTOAddress);

        public Task UpdateAddress(DTOUpdateAddress address);

        public Task DeleteAddress(int id);
    }
}
