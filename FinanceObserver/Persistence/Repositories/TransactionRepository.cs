using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence.Repositories;

public class TransactionRepository : Repository<Transaction>, ITransactionRepository
{
    public TransactionRepository(DbContext dbcontext) : base(dbcontext)
    {
    }

    public IQueryable<Transaction> GetAllByAccountId(int accountId)
    {
        throw new NotImplementedException();
    }
}