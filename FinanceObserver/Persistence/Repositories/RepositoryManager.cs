using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence.Repositories;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly Lazy<IRepository<Client?>> _lazyClientRepository;
    private readonly Lazy<IRepository<Account>> _lazyAccountRepository;
    private readonly Lazy<IRepository<Transaction>> _lazyTransactionRepository;
    private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

    public RepositoryManager(DbContext dbContext)
    {
        _lazyClientRepository = new Lazy<IRepository<Client?>>(() => new ClientRepository(dbContext));
        _lazyAccountRepository = new Lazy<IRepository<Account>>(() => new AccountRepository(dbContext));
        _lazyTransactionRepository = new Lazy<IRepository<Transaction>>(() => new TransactionRepository(dbContext));
        _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
    }
    
    public IRepository<Client?> ClientRepository => _lazyClientRepository.Value;

    public IRepository<Account> AccountRepository => _lazyAccountRepository.Value;

    public IRepository<Transaction> TransactionRepository => _lazyTransactionRepository.Value;

    public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
}