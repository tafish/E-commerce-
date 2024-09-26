﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DTOs
{
    public class DTOProduct
    {    
        public int Id { get; set; }     
        public string? Name { get; set; }   
        public string? Description { get; set; }    
        public double? Price { get; set; }
    }
}
