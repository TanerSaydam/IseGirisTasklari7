using MediatR;

namespace IseGirisTasklari7.Application.Features.Companies.Commands.UpdateCompany;

public sealed record UpdateCompanyCommand(
    string CompanyId,
    int OrderStartTimeHour,
    int OrderStartTimeMinute) : IRequest<UpdateCompanyCommandResponse>;
