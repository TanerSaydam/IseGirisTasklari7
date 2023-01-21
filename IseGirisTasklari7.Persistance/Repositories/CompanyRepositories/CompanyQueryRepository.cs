using IseGirisTasklari7.Domain.Entities;
using IseGirisTasklari7.Domain.Repositories.CompanyRepositories;
using IseGirisTasklari7.Persistance.Context;

namespace IseGirisTasklari7.Persistance.Repositories.CompanyRepositories;

public sealed class CompanyQueryRepository : QueryRepository<Company>, ICompanyQueryRepository
{
    public CompanyQueryRepository(AppDbContext context) : base(context)
    {
    }
}
