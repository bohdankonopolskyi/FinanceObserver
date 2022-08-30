using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence.Repositories;

public class AccountRepository : Repository<Account>
{
    public AccountRepository(DbContext dbcontext) : base(dbcontext)
    {
    }
} 