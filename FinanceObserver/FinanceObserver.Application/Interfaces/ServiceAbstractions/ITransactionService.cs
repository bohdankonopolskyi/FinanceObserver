using System.Transactions;
namespace FinanceObserver.Application.Interfaces.Services
{
    public interface ITransactionService
    {
        Task<IEnumerable<Transaction>> GetAllTransactionsAsync(int accountId, CancellationToken cancellationToken = default);
        Task<Transaction> GetTransactionByIdAsync(int transactionId, int accountId,
            CancellationToken cancellationToken = default);
        Task<Transaction> CreateAsync(int accountId, CancellationToken cancellationToken = default);
        Task DeleteAsync(int transactionId, int accountId, CancellationToken cancellationToken = default);
    }
}