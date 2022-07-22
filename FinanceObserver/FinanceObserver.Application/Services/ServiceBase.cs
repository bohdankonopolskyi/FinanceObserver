using FinanceObserver.Application.Interfaces.Persistance;

namespace FinanceObserver.Application.Services;

public abstract class ServiceBase<TEntity> where TEntity : class
{
public IRepository<TEntity> _repository;

protected ServiceBase(IRepository<TEntity> repository)
{
    _repository = repository;
}
}