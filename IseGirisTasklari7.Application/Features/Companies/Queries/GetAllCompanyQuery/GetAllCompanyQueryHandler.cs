using IseGirisTasklari7.Application.Services;
using MediatR;

namespace IseGirisTasklari7.Application.Features.Companies.Queries.GetAllCompanyQuery;

public sealed class GetAllCompanyQueryHandler : IRequestHandler<GetAllCompanyQuery, GetAllCompanyQueryResponse>
{
    private readonly ICompanyService _companyService;

    public GetAllCompanyQueryHandler(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    public async Task<GetAllCompanyQueryResponse> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
    {
        GetAllCompanyQueryResponse response = new(_companyService.GetAll());
        return response;
    }
}
