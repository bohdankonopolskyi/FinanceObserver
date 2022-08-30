using AutoMapper;
using FinanceObserver.Application.DTO;
using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Application.Interfaces.ServiceAbstractions;
using FinanceObserver.Domain.Model.Exceptions;
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Services;

public class AccountService : ServiceBase<Account>, IAccountService
{
    public AccountService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
    {
    }

    public IEnumerable<AccountDto> GetAllAccountsByOwnerId(int ownerId, CancellationToken cancellationToken = default)
    {
        var accounts = _repositoryManager.AccountRepository.Find(x => x.ClientId == ownerId).AsEnumerable();
        var accountsDto = _mapper.Map<IEnumerable<Account>, IEnumerable<AccountDto>>(accounts);

        return accountsDto;
    }

    public AccountDto GetAccountById(int accountId, CancellationToken cancellationToken = default)
    {
        var account = _repositoryManager.AccountRepository.GetById(accountId);
        if (account is null)
            throw new Exception("Account is not found");
        var accountDto = _mapper.Map<Account, AccountDto>(account);
        
        return accountDto;
    }

    public void CreateAccount(int ownerId, AccountForCreationDto accountForCreationDto,
        CancellationToken cancellationToken = default)
    {
        var owner = _repositoryManager.ClientRepository.GetById(ownerId);
        if (owner is null)
            throw new ClientNotFoundException($"Owner with id {owner} was not found");
        
        var account = _mapper.Map<AccountForCreationDto, Account>(accountForCreationDto);
        account.ClientId = owner.Id;

        _repositoryManager.AccountRepository.Add(account);
        _repositoryManager.UnitOfWork.SaveChangesAsync(default);
    }

    public void DeleteAccount(int ownerId, int accountId, CancellationToken cancellationToken = default)
    {
        var owner = _repositoryManager.ClientRepository.GetById(ownerId);
        if (owner is null)
            throw new ClientNotFoundException($"Owner with id {owner} was not found");
        
        var account = _repositoryManager.AccountRepository.GetAll()
            .SingleOrDefault(x => x.Id == accountId && x.ClientId == owner.Id);
        
        if (account != null) 
            _repositoryManager.AccountRepository.Delete(account);
        
        _repositoryManager.UnitOfWork.SaveChangesAsync(default);

    }
}