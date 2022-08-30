namespace FinanceObserver.Application.Interfaces.Persistance;

public interface IUnitOfWork
{
    void SaveChangesAsync(CancellationToken cancellationToken = default);
}