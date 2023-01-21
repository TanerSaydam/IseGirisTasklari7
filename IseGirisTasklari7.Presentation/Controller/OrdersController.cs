using IseGirisTasklari7.Application.Features.Orders.Commands.CreateOrderCommand;
using IseGirisTasklari7.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IseGirisTasklari7.Presentation.Controller;

public sealed class OrdersController : ApiController
{        
    public OrdersController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateOrder(CreateOrderCommand request)
    {
        CreateOrderCommandResponse response =  await _mediator.Send(request);
        return Ok(response);
    }
}
