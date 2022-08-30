using AutoMapper;
using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Application.Interfaces.ServiceAbstractions;

namespace FinanceObserver.Application.Services;

public class ServiceManager : IServiceManager
{
    private Lazy<ClientService> _lazyClientService;
    private Lazy<IAccountService> _lazyAccountService;
    private Lazy<ITransactionService> _lazyTransactionService;

    public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _lazyClientService = new Lazy<ClientService>(() => new ClientService(repositoryManager, mapper));
        _lazyAccountService = new Lazy<IAccountService>(() => new AccountService(repositoryManager, mapper));
        _lazyTransactionService = new Lazy<ITransactionService>(() => new TransactionService(repositoryManager, mapper));
    }

    public IClientService ClientService => _lazyClientService.Value;

    public IAccountService AccountService => _lazyAccountService.Value;

    public ITransactionService TransactionService => _lazyTransactionService.Value;
}