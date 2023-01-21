using IseGirisTasklari7.Application.Features.Products.Commands.CreateProduct;
using IseGirisTasklari7.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IseGirisTasklari7.Presentation.Controller;

public sealed class ProductsController : ApiController
{
    public ProductsController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateProduct(CreateProductCommand request)
    {
        CreateProductCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    
}
