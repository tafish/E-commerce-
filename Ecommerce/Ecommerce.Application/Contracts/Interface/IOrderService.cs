using Ecommerce.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Contracts.Interface
{
    public interface IOrderService
    {
        public Task CreateOrder(DTOOrder DTOOrder);
        public Task DeleteOrder(int id);
        public Task ChangeOrderStatus(int orderId, string newStatus);

    }
}
