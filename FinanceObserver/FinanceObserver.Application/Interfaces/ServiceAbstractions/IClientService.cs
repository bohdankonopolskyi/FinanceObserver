using FinanceObserver.Application.DTO;
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Interfaces.ServiceAbstractions;

public interface IClientService
{
    Client GetClientByIdAsync(int clientId, CancellationToken cancellationToken = default);
    void CreateClientAsync(ClientForCreationDto forCreationDto, CancellationToken cancellationToken = default);
    void UpdateAsync(int clientId, ClientForCreationDto clientForUpdateDto, CancellationToken cancellationToken = default);
    void DeleteAsync(int clientId, CancellationToken cancellationToken = default);
}