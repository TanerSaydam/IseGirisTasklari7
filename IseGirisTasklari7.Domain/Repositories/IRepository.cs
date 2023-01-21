using IseGirisTasklari7.Domain.Primitives;
using Microsoft.EntityFrameworkCore;

namespace IseGirisTasklari7.Domain.Repositories;

public interface IRepository<T>
    where T: Entity
{
    DbSet<T> Entity { get; set; }
}
