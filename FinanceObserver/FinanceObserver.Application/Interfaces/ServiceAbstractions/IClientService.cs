using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Interfaces.Services;

public interface IClientService
{
    Task<Client> GetClientByIdAsync(int clientId, CancellationToken cancellationToken = default);
    Task<Client> CreateAsync(CancellationToken cancellationToken = default);
    Task UpdateAsync(int clientId, CancellationToken cancellationToken = default);
    Task DeleteAsync(int clentId, CancellationToken cancellationToken = default);
}