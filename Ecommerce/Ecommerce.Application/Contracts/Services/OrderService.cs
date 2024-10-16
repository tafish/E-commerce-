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
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository OrderRepository, IMapper mapper)
        {
            _OrderRepository = OrderRepository;
            _mapper = mapper;
        }

        public async Task CreateOrder(DTOOrder DTOOrder)
        {
            var catmapModel = _mapper.Map<Order>(DTOOrder);
            await _OrderRepository.AddAsync(catmapModel);
        }

        public async Task DeleteOrder(int id)
        {
            await _OrderRepository.DeleteAsync(id);
        }
        Task IOrderService.ChangeOrderStatus(int orderId, string newStatus)
        {
            if(orderId <= 0)
            {
                throw new ArgumentException("Invalid order ID");
            }

            if (string.IsNullOrEmpty(newStatus))
            {
                throw new ArgumentException("New status cannot be null or empty");
            }

            Console.WriteLine($"Order {orderId} status changed to {newStatus}");

            return Task.CompletedTask;
        }
    }
}
