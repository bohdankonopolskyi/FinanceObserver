using AutoMapper;
using FinanceObserver.Application.DTO;
using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Application.Interfaces.ServiceAbstractions;
using FinanceObserver.Domain.Model.Exceptions;
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Services;

public class ClientService : ServiceBase<Client>, IClientService
{
    public ClientService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
    {
        
    }

    public Client GetClientByIdAsync(int clientId, CancellationToken cancellationToken = default)
    {
        var client = _repositoryManager.ClientRepository.GetById(clientId);
        if (client is null)
            throw new ClientNotFoundException("Client not found");
        
        return client;
    }


    public void CreateClientAsync(ClientForCreationDto forCreationDto, CancellationToken cancellationToken = default)
    {
        Client? client = _mapper.Map<ClientForCreationDto, Client>(forCreationDto);
        _repositoryManager.ClientRepository.Add(client);
        _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken = default);
    }

    public void UpdateAsync(int clientId, ClientForCreationDto clientForUpdateDto,  CancellationToken cancellationToken = default)
    {
        var client = _repositoryManager.ClientRepository.GetById(clientId);
        if (client != null)
        {
            var updatedUser = _mapper.Map<ClientForCreationDto, Client>(clientForUpdateDto);
            _repositoryManager.ClientRepository.Update(updatedUser);
            _repositoryManager.UnitOfWork.SaveChangesAsync(default);
        }
    }

    public void DeleteAsync(int clientId, CancellationToken cancellationToken = default)
    {
        var client = _repositoryManager.ClientRepository.GetById(clientId);
        if (client != null)
        {
            _repositoryManager.ClientRepository.Delete(client);
            _repositoryManager.UnitOfWork.SaveChangesAsync(default);
        }
    }
}