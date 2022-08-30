using Microsoft.EntityFrameworkCore;
using FinanceObserver.Domain.Models;
namespace FinanceObserver.Application.Interfaces.Persistance;

public interface ITransactionRepository
{
    IQueryable<Transaction> GetAllByAccountId(int accountId);
}