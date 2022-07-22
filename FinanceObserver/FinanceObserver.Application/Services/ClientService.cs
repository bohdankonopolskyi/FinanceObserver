using FinanceObserver.Application.Interfaces.Services;
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Services;

public class ClientService : IClientService
{
    public Task<Client> GetClientByIdAsync(int clientId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Client> CreateAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(int clientId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int clentId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}