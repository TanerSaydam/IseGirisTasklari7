using IseGirisTasklari7.Domain.Entities;
using IseGirisTasklari7.Domain.Repositories.CompanyRepositories;
using IseGirisTasklari7.Persistance.Context;

namespace IseGirisTasklari7.Persistance.Repositories.CompanyRepositories;

public sealed class CompanyCommandRepository : CommandRepository<Company>, ICompanyCommandRepository
{
    public CompanyCommandRepository(AppDbContext context) : base(context)
    {
    }
}
