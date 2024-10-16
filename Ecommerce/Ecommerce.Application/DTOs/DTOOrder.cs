using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTOs
{
    public class DTOOrder
    {
        public double TotalAmount { get; set; }
        public int status { get; set; }
        public int UserId { get; set; }
    }
    public class DTOCreateOrder
    {
        public ICollection<OrderItem> OrderItems { get; set; }
        public int UserId { get; set; }
    }
}
