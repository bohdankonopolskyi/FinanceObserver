using FinanceObserver.Domain.Models;
using Persistence.Data;

namespace Persistence.Repositories;

public class AccountRepository : Repository<Account>
{
    public AccountRepository(FinanceObserverDbContext dbcontext) : base(dbcontext)
    {
    }

    public override Task<Account> GetByIdAsync(int id)
    {
        return Task.FromResult(_dbcontext.Set<Account>().SingleOrDefault(x => x.Id == id));
    }
} 