using IseGirisTasklari7.Domain.Entities;
using IseGirisTasklari7.Persistance.Constans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IseGirisTasklari7.Persistance.Configurations;

public sealed class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable(TableNames.Companies);
        builder.HasKey(x => x.Id);        
    }
}
