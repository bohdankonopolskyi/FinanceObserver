using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable("Transactions").HasKey(k => k.Id);
        builder.Property(p => p.Id).HasColumnName("TransactionId");
        builder
            .HasOne(p => p.Account)
            .WithMany()
            .HasForeignKey(p => p.AccountId);
    }
}