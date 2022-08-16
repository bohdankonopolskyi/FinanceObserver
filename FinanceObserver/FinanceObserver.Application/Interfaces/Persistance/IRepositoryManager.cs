using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Interfaces.Persistance;

public interface IRepositoryManager
{
     IRepository<Client> ClientRepository { get; }
    IRepository<Account> AccountRepository { get; }
    IRepository<Transaction> TransactionRepository { get; }
    IUnitOfWork UnitOfWork { get; }
}