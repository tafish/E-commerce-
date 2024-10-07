using Ecommerce.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Behaviors.Validation
{
    public class BradValidator : AbstractValidator<DTOBrand>

    {
        public BradValidator()
        {
            RuleFor(c => c.Name).NotNull().WithMessage("Please insert category !")
                .Length(2, 50).WithMessage("Min chars is 2 and max is 50");
        }
    }
}
