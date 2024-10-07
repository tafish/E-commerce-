using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTOs
{
    public class DTOAddress
    {
      
        public string city { get; set; }
        public string content { get; set; }
        public class DTOUpdateAddress
        {
            public int Id { get; set; }
            public string content { get; set; }
            public string city { get; set; }
        }

    }
}
