using IseGirisTasklari7.Domain.Entities;
using IseGirisTasklari7.Domain.Repositories.OrderRepositories;
using IseGirisTasklari7.Persistance.Context;

namespace IseGirisTasklari7.Persistance.Repositories.OrderRepositories;

public sealed class OrderCommandRepository : CommandRepository<Order>, IOrderCommandRepository
{
    public OrderCommandRepository(AppDbContext context) : base(context)
    {
    }
}
