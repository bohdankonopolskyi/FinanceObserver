using FinanceObserver.Application.DTO;
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Interfaces.ServiceAbstractions;

public interface IClientService
{
    Task<Client?> GetClientByIdAsync(int clientId, CancellationToken cancellationToken = default);
    Task<Client> CreateClientAsync(ClientForCreationDto forCreationDto, CancellationToken cancellationToken = default);
    Task UpdateAsync(int clientId, CancellationToken cancellationToken = default);
    Task DeleteAsync(int clentId, CancellationToken cancellationToken = default);
}