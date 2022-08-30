using System.Linq.Expressions;
using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;
using static System.Threading.Tasks.Task;


namespace Persistence.Repositories;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly DbContext _dbcontext;

    protected Repository(DbContext dbcontext)
    {
        _dbcontext = dbcontext ?? throw new ArgumentNullException(nameof(dbcontext));
    }

    public TEntity? GetById(int id) => _dbcontext.Set<TEntity>().SingleOrDefault(x => x.Id == id);

    public IQueryable<TEntity> GetAll() => _dbcontext.Set<TEntity>().AsNoTracking();

    public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) => _dbcontext.Set<TEntity>().Where(predicate).AsNoTracking();
    
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