using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("Clients").HasKey(k => k.Id);
        builder.Property(p => p.Id).HasColumnName("ClientId");
        builder.Property(p => p.Name).HasMaxLength(50);
    }
}