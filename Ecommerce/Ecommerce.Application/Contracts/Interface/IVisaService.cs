using Ecommerce.Application.DTOs;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ecommerce.Application.DTOs.DTOvisa;

namespace Ecommerce.Application.Contracts.Interface
{
    public interface IVisaService
    {
        public Task<IEnumerable<visa>> GetAllVisa();

        public Task<visa> GetVisaById(int id);

        public Task CreateVisa(DTOvisa DTOvisa);

        public Task UpdateVisa(DTOUpdatevisa visa);

        public Task DeleteVisa(int id);
    }
}
