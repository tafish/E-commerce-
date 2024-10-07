using Ecommerce.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Behaviors.Validation
{
    public class ReviewValidator : AbstractValidator<DTOReview>
    {
        public ReviewValidator()
        {
            RuleFor(c => c.Comment).NotNull().WithMessage("Please insert Product !")
              .Length(2, 50).WithMessage("min id to and max is Fifty");
        }
    }
}
