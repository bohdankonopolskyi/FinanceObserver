using FinanceObserver.Application.Interfaces.Services;

namespace FinanceObserver.Application.Interfaces.ServiceAbstractions;

public interface IServiceManager
{
    IClientService ClientService { get;}
    IAccountService AccountService { get; }
    ITransactionService TransactionService { get;}
    
}