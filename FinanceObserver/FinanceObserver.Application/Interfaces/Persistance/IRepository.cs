using System.Linq.Expressions;

namespace FinanceObserver.Application.Interfaces.Persistance;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity?> GetByIdAsync(int id);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<IQueryable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);

    void Add(TEntity? entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);
}