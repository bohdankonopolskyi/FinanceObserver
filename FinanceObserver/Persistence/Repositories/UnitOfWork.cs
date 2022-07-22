
using FinanceObserver.Application.Interfaces.Persistance;
using Persistence.Data;

namespace Persistence.Repositories;

public sealed class UnitOfWork : IUnitOfWork
{
    private readonly FinanceObserverDbContext _dbContext;

    public UnitOfWork(FinanceObserverDbContext context)
    {
        _dbContext = context;
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
    
        _dbContext.SaveChangesAsync(cancellationToken);
    
}