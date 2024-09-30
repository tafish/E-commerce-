using Ecommerce.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Behaviors.Validation
{
    public class ProductValidator : AbstractValidator<DTOProduct>
    {
        public ProductValidator()
        {
            RuleFor(c => c.Name).NotNull().WithMessage("Please insert Product !")
               .Length(10, 50).WithMessage("Please insert name ");

            RuleFor(c => c.Description).NotNull().WithMessage("Please insert Description Product !")
             .Length(30, 250).WithMessage("Please insert Description ");

            RuleFor(c => c.Price).NotNull().WithMessage("Please insert Price Product !")
               
                ;
            
        }
    }
}

