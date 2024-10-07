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
               .Length(2, 50).WithMessage("min id to and max is Fifty");

            RuleFor(c => c.Description).NotNull().WithMessage("Please insert Description Product !")
             .Length(30, 250).WithMessage("The magnification and the lens range from Thirty to Fifty");

            RuleFor(c => c.Price).NotNull().WithMessage("Please insert Price Product !")
                .GreaterThan(0).LessThan(10000)
                ;



        }
    }
}

