using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class Address
    {
        public int id { get; set; }
        public string content { get; set; }
        public string city { get; set; }
        public string type { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
