using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTOs
{
    public class DTOvisa
    {
        public int id { get; set; }
        public int number { get; set; }
        public string Evpiry_date { get; set; }
        public string type { get; set; }
        public int UserId { get; set; }
       

        public class DTOUpdatevisa
        {
            public int id { get; set; }
            public int number { get; set; }
            
        }
    }
}