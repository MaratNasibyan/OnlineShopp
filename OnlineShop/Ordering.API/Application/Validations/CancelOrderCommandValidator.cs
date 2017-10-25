using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ordering.API.Application.Commands;
using FluentValidation;

namespace Ordering.API.Application.Validations
{
    public class CancelOrderCommandValidator : AbstractValidator<CancelOrderCommand>
    {
        public CancelOrderCommandValidator()
        {
            RuleFor(order => order.OrderNumber).NotEmpty().WithMessage("No orderId found");
        }
    }
}
