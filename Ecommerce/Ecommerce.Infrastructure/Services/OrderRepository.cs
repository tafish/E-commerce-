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
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(DBContextApplication context) : base(context)
        {
        }

        public Task ChangeOrderStatus(int orderId, string newStatus)
        {
            throw new NotImplementedException();
        }
    }
}
