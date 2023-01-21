using IseGirisTasklari7.Domain.Primitives;

namespace IseGirisTasklari7.Domain.Entities;

public sealed class Company : Entity
{
    public string CompanyName { get; set; }
    public bool ApprovalStatus { get; set; }
    public int OrderStartTimeHour { get; set; }
    public int OrderStartTimeMinute { get; set; }
    public int OrderFinishTimeHour { get; set; }    
    public int OrderFinishTimeMinute { get; set; }    
    public ICollection<Product> Products { get; set; }

}
