using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Configuration;

namespace Persistence.Data;

public class FinanceObserverDbContext : DbContext
{
    public DbSet<Client>? Clients { get; set; }
    public  DbSet<Account>? Accounts { get; set; }
    public DbSet<Transaction>? Transactions { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(
            @"Server=localhost:1433;Database=FinanceObserver;User=SA;Password=SQLServer3165;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new AccountConfiguration().Configure(modelBuilder.Entity<Account>());
        new ClientConfiguration().Configure(modelBuilder.Entity<Client>());
        new TransactionConfiguration().Configure(modelBuilder.Entity<Transaction>());
    }
}