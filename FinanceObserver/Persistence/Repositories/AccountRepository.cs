using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence.Repositories;

public class AccountRepository : Repository<Account>
{
    public AccountRepository(DbContext dbcontext) : base(dbcontext)
    {
    }

    // public Task<Account> GetByIdAsync(int id)
    // {
    //     return Task.FromResult(_dbcontext.Set<Account>().SingleOrDefault(x => x.Id == id));
    // }
} 