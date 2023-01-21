namespace IseGirisTasklari7.Domain;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
}
