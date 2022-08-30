
using FinanceObserver.Application.DTO;
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Interfaces.ServiceAbstractions;

public interface IAccountService
{
 IEnumerable<AccountDto> GetAllAccountsByOwnerId(int ownerId, CancellationToken cancellationToken = default);
 AccountDto GetAccountById(int accountId, CancellationToken cancellationToken = default);
 void CreateAccount(int ownerId, AccountForCreationDto accountForCreationDto, CancellationToken cancellationToken = default);
 void DeleteAccount(int ownerId, int accountId, CancellationToken cancellationToken = default);
 
}