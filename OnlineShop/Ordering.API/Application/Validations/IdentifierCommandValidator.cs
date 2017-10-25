using FluentValidation;
using Ordering.API.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.API.Application.Validations
{
    public class IdentifierCommandValidator : AbstractValidator<IdentifiedCommand<CreateOrderCommand, bool>>
    {
        public IdentifierCommandValidator()
        {
            RuleFor(command => command.Id).NotEmpty();
        }
    }
}
