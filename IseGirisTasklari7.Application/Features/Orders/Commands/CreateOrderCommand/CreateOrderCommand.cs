using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseGirisTasklari7.Application.Features.Orders.Commands.CreateOrderCommand
{
    public sealed record CreateOrderCommand(
        string FirmaId,
        string ProductId,
        string CustomerName) : IRequest<CreateOrderCommandResponse>;
}
