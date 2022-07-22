using System.Transactions;
using FinanceObserver.Application.Interfaces.Services;

namespace Services.Abstractions;

public interface IServiceManager
{
    IClientService ClientService { get; set; }
    IAccountService AccountService { get; set; }
    ITransactionService TransactionService { get; set; }
    
}