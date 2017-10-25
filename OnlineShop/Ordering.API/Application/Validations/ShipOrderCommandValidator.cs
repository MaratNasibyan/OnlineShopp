using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ordering.API.Application.Commands;
using FluentValidation;

namespace Ordering.API.Application.Validations
{
    public class ShipOrderCommandValidator : AbstractValidator<ShipOrderCommand>
    {
        public ShipOrderCommandValidator()
        {
            RuleFor(order => order.OrderNumber).NotEmpty().WithMessage("No orderId found");
        }
    }
}
