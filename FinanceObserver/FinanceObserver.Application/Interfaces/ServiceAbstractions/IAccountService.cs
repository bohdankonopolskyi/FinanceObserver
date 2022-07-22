
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Interfaces.Services;

public interface IAccountService
{
 Task<IEnumerable<Account>> GetAllByOwnerIdAsync(int ownerId, CancellationToken cancellationToken = default);
 Task<Account> GetByIdAsync(int ownerId, int accountId, CancellationToken cancellationToken = default);
 Task<Account> CreateAsync(int ownerId, CancellationToken cancellationToken = default);
 Task DeleteAsync(int ownerId, int accountId, CancellationToken cancellationToken = default);
}