using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTOs
{
    public class DTOReview
    {   
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public int ProductId { get; set; }

        public class DTOUpdateReview
        {
            public int Id { get; set; }
            public string Comment { get; set; }
            public DateTime Date { get; set; }
            public int UserId { get; set; }
        }


    }
}
