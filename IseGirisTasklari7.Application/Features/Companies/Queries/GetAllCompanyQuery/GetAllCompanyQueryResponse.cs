using IseGirisTasklari7.Domain.Entities;

namespace IseGirisTasklari7.Application.Features.Companies.Queries.GetAllCompanyQuery;

public sealed record GetAllCompanyQueryResponse(
    IQueryable<Company> Companies);

