using IseGirisTasklari7.Domain.Primitives;
using IseGirisTasklari7.Domain.Repositories;
using IseGirisTasklari7.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IseGirisTasklari7.Persistance.Repositories;

public class QueryRepository<T> : IQueryRepository<T>
    where T: Entity
{
    private readonly AppDbContext _context;

    private readonly Func<AppDbContext,string,Task<T>> GetByIdCompiled =
        EF.CompileAsyncQuery((AppDbContext context, string id) 
            => 
        context.Set<T>().FirstOrDefault(p=> p.Id == id));

    public QueryRepository(AppDbContext context)
    {
        _context = context;
        Entity = _context.Set<T>();
    }

    public DbSet<T> Entity { get; set; }

    public IQueryable<T> GetAll()
    {
        return Entity.AsQueryable();
    }

    public async Task<T> GetFirstByExpiression(Expression<Func<T, bool>> expression)
    {
        return await Entity.FirstOrDefaultAsync(expression);
    }

    public async Task<T> GetFirstById(string id)
    {
        return await GetByIdCompiled(_context,id);
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
    {
        return Entity.Where(expression);
    }
}
