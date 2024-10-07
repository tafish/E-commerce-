using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTOs
{
    public class DTOBrand
    {
        public string Name { get; set; }

        public class DTOUpdateBrand
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
