using IseGirisTasklari7.Domain;
using IseGirisTasklari7.Persistance.Context;

namespace IseGirisTasklari7.Persistance;

public sealed class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();   
    }
}
