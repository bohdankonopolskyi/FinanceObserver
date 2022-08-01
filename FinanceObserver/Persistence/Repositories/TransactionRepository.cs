using FinanceObserver.Domain.Models;
using Persistence.Data;

namespace Persistence.Repositories;

public class TransactionRepository : Repository<Transaction>
{
    public TransactionRepository(FinanceObserverDbContext dbcontext) : base(dbcontext)
    {
    }

    public override Task<Transaction> GetByIdAsync(int id)
    {
        return Task.FromResult(_dbcontext.Set<Transaction>().SingleOrDefault(x => x.Id == id));
    }
}