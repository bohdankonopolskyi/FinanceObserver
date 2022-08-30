
using FinanceObserver.Application.DTO;
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Interfaces.ServiceAbstractions
{
    public interface ITransactionService
    {
        IEnumerable<TransactionDto> GetAllTransactions(int accountId, CancellationToken cancellationToken = default);
       TransactionDto GetTransactionById(int transactionId, int accountId,
            CancellationToken cancellationToken = default);
        void Create(int accountId, TransactionForCreationDto transactionForCreationDto, CancellationToken cancellationToken = default);
        void Delete(int accountId, int transactionId, CancellationToken cancellationToken = default);
    }
}