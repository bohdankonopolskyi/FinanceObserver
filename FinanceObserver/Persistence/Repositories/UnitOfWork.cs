
using FinanceObserver.Application.Interfaces.Persistance;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence.Repositories;

public sealed class UnitOfWork : IUnitOfWork
{
    private readonly DbContext _dbContext;

    public UnitOfWork(DbContext context)
    {
        _dbContext = context;
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
    
        _dbContext.SaveChangesAsync(cancellationToken);
    
}