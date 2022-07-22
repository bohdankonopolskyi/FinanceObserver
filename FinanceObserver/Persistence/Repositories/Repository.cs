using System.Linq.Expressions;
using FinanceObserver.Application.Interfaces.Persistance;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;


namespace Persistence.Repositories;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly FinanceObserverDbContext _dbcontext;

    protected Repository(FinanceObserverDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }


    public abstract Task<TEntity> GetByIdAsync(int id);

    public Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<TEntity>>(_dbcontext.Set<TEntity>().AsNoTracking());
    }

    public Task<IQueryable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
    {
        return Task.FromResult(_dbcontext.Set<TEntity>().Where(predicate).AsNoTracking());
    }

    public void Add(TEntity? entity)
    {
        if (entity != null) 
            _dbcontext.Set<TEntity>().Add(entity);
    }

    public void Update(TEntity? entity)
    {
        if (entity != null) 
            _dbcontext.Set<TEntity>().Update(entity);
    }

    public void Delete(TEntity? entity)
    {
        if (entity != null) 
            _dbcontext.Set<TEntity>().Remove(entity);
    }
}