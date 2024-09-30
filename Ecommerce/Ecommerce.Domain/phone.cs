using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public class phone
    {
        public int id { get; set; }

        public string no { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
