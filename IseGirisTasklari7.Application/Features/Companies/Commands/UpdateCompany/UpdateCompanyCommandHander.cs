using IseGirisTasklari7.Application.Services;
using MediatR;

namespace IseGirisTasklari7.Application.Features.Companies.Commands.UpdateCompany;

public sealed class UpdateCompanyCommandHander : IRequestHandler<UpdateCompanyCommand, UpdateCompanyCommandResponse>
{
    private readonly ICompanyService _companyService;

    public UpdateCompanyCommandHander(ICompanyService companyService)
    {
        _companyService = companyService;
    }

    public async Task<UpdateCompanyCommandResponse> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
    {
        await _companyService.UpdateCompanyAsync(request);
        return new();
    }
}
