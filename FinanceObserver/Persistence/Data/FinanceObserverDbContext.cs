using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Configuration;
using Microsoft.Extensions.Configuration;
namespace Persistence.Data;

public class FinanceObserverDbContext : DbContext
{
    public DbSet<Client>? Clients { get; set; }
    public  DbSet<Account>? Accounts { get; set; }
    public DbSet<Transaction>? Transactions { get; set; }

    private IConfiguration _configuration;

    // public FinanceObserverDbContext(IConfiguration configuration)
    // {
    //     _configuration = configuration;
    // }
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
    //     optionsBuilder.UseSqlServer(
    //         _configuration["sqlServerConnection:connectionString"] ?? throw new InvalidOperationException());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new AccountConfiguration().Configure(modelBuilder.Entity<Account>());
        new ClientConfiguration().Configure(modelBuilder.Entity<Client>());
        new TransactionConfiguration().Configure(modelBuilder.Entity<Transaction>());
    }
}