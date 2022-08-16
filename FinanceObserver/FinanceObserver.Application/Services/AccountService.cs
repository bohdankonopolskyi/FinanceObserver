using AutoMapper;
using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Application.Interfaces.Services;
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Services;

public class AccountService : ServiceBase<Account>, IAccountService
{
    public AccountService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
    {
    }

    public Task<IEnumerable<Account>> GetAllByOwnerIdAsync(int ownerId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Account> GetByIdAsync(int ownerId, int accountId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Account> CreateAsync(int ownerId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int ownerId, int accountId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}