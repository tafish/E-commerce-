using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTOs
{
    public class DTOWishlist
    {

        public int? ProductId { get; set; }
        
        public int UserId { get; set; }

    }
}
