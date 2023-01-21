using IseGirisTasklari7.Application.Features.Companies.Commands.CreateCompany;
using IseGirisTasklari7.Application.Features.Companies.Commands.UpdateCompany;
using IseGirisTasklari7.Application.Features.Companies.Queries.GetAllCompanyQuery;
using IseGirisTasklari7.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IseGirisTasklari7.Presentation.Controller;

public class CompaniesController : ApiController
{
    public CompaniesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateCompany(CreateCompanyCommand request)
    {
        CreateCompanyCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> UpdateCompany(UpdateCompanyCommand request)
    {
        UpdateCompanyCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> GetAllCompany()
    {
        GetAllCompanyQuery request = new();
        GetAllCompanyQueryResponse response = await _mediator.Send(request);
        return Ok(response);
    }

}
