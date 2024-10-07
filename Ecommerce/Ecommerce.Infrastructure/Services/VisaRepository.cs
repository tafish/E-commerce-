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
    public class VisaRepository : Repository<visa>, IVisaRepository
    {
        public VisaRepository(DBContextApplication context) : base(context)
        {
        }
    
    }
}
