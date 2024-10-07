using Ecommerce.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Behaviors.Validation
{
    public class visaValidator : AbstractValidator<DTOvisa>
    {
        public visaValidator()
        {

            RuleFor(c => c.number).NotNull().LessThanOrEqualTo(14);
       
            RuleFor(c => c.type).NotNull().WithMessage("Please insert type !")
             .Length(2, 50).WithMessage("Min chars is 2 and max is 50");
        }
    }
}
