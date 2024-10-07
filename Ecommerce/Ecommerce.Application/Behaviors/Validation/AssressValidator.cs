using Ecommerce.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Behaviors.Validation
{
    public class AssressValidator : AbstractValidator<DTOAddress>
    {
        public AssressValidator()
        {

            RuleFor(c => c.city).NotNull().WithMessage("Please insert city !");
              
        }
    }
}
