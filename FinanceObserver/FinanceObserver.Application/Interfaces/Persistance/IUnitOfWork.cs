namespace FinanceObserver.Application.Interfaces.Persistance;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}