using MediatR;

namespace IseGirisTasklari7.Application.Features.Companies.Queries.GetAllCompanyQuery;

public sealed record GetAllCompanyQuery: IRequest<GetAllCompanyQueryResponse>;
