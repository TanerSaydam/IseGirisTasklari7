using MediatR;

namespace IseGirisTasklari7.Application.Features.Companies.Commands.CreateCompany;

public sealed record CreateCompanyCommand(
    string CompanyName,        
    int OrderStartTimeHour,
    int OrderStartTimeMinute,
    int OrderFinishTimeHour,
    int OrderFinishTimeMinute) : IRequest<CreateCompanyCommandResponse>;
