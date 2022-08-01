using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("Accounts").HasKey(k => k.Id);
        builder.Property(p => p.Id).HasColumnName("AccountId");
        builder.HasOne(p => p.Client)
            .WithMany(x => x.Accounts)
            .HasForeignKey(p => p.ClientId);
    }
}