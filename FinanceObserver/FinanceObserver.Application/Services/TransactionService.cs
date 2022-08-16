using AutoMapper;
using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Application.Interfaces.Services;
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Services;

public class TransactionService : ServiceBase<Transaction>, ITransactionService
{
    public TransactionService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
    {
    }

    public Task<IEnumerable<System.Transactions.Transaction>> GetAllTransactionsAsync(int accountId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<System.Transactions.Transaction> GetTransactionByIdAsync(int transactionId, int accountId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<System.Transactions.Transaction> CreateAsync(int accountId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int transactionId, int accountId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}