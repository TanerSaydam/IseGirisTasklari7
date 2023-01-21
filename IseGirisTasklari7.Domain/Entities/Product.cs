using IseGirisTasklari7.Domain.Primitives;

namespace IseGirisTasklari7.Domain.Entities;

public sealed class Product : Entity
{
    public string ProductName { get; set; }
    public decimal Stock { get; set; }
    public decimal Price { get; set; }
    
    public string CompanyId { get; set; }
    public Company Company { get; set; }

    public ICollection<Order> Orders { get; set; }
}
