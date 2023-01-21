using IseGirisTasklari7.Domain.Entities;
using IseGirisTasklari7.Domain.Repositories.ProductRepositories;
using IseGirisTasklari7.Persistance.Context;

namespace IseGirisTasklari7.Persistance.Repositories.ProductRepositories;

public sealed class ProductQueryRepository : QueryRepository<Product>, IProductQueryRepository
{
    public ProductQueryRepository(AppDbContext context) : base(context)
    {
    }
}
