using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence.Repositories;

public class TransactionRepository : Repository<Transaction>
{
    public TransactionRepository(DbContext dbcontext) : base(dbcontext)
    {
    }

    // public  Task<Transaction> GetByIdAsync(int id)
    // {
    //     return Task.FromResult(_dbcontext.Set<Transaction>().SingleOrDefault(x => x.Id == id));
    // }
}