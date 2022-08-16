using AutoMapper;
using FinanceObserver.Application.DTO;
using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Application.Interfaces.ServiceAbstractions;
using FinanceObserver.Application.Interfaces.Services;
using FinanceObserver.Domain.Model.Exceptions;
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Services;

public class ClientService : ServiceBase<Client>, IClientService
{
    public ClientService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
    {
        
    }

    public Task<Client?> GetClientByIdAsync(int clientId, CancellationToken cancellationToken = default)
    {
       var client = _repositoryManager.ClientRepository.GetByIdAsync(clientId);
       if (client.Result != null)
       {
           return client;
       }
       else
       {
           throw new ClientException("Client not found");
       }
    }


    public Task<Client> CreateClientAsync(ClientForCreationDto forCreationDto, CancellationToken cancellationToken = default)
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