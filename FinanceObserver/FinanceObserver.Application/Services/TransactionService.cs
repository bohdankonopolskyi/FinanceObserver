using AutoMapper;
using FinanceObserver.Application.DTO;
using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Application.Interfaces.ServiceAbstractions;
using FinanceObserver.Domain.Models;
using Exception = System.Exception;

namespace FinanceObserver.Application.Services;

public class TransactionService : ServiceBase<Transaction>, ITransactionService
{
    public TransactionService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
    {
    }

    public IEnumerable<TransactionDto> GetAllTransactions(int accountId, CancellationToken cancellationToken = default)
    {
        var account = _repositoryManager.AccountRepository.GetById(accountId);
        if (account is null)
            throw new Exception("Account not found");
        var transactions = _repositoryManager.TransactionRepository.Find(x => x.AccountId == account.Id).AsEnumerable();
        var transactionDtos = _mapper.Map<IEnumerable<Transaction>, IEnumerable<TransactionDto>>(transactions);
        
        return transactionDtos;
    }

    public TransactionDto GetTransactionById(int transactionId, int accountId, CancellationToken cancellationToken = default)
    {
        var account = _repositoryManager.AccountRepository.GetById(accountId);
        if (account is null)
            throw new Exception("Account not found");
        var transaction =
            _repositoryManager.TransactionRepository.GetById(accountId);

        if (transaction is null)
            throw new Exception("Transaction not found");
        
        var transactionDto = _mapper.Map<Transaction, TransactionDto>(transaction);

        return transactionDto;
    }

    public void Create(int accountId, TransactionForCreationDto transactionForCreationDto,
        CancellationToken cancellationToken = default)
    {
        var account = _repositoryManager.AccountRepository.GetById(accountId);
        if (account is null)
            throw new Exception("Account not found");
        var transaction = _mapper.Map<TransactionForCreationDto, Transaction>(transactionForCreationDto);
        _repositoryManager.TransactionRepository.Add(transaction);
        _repositoryManager.UnitOfWork.SaveChangesAsync(default);
    }

    public void Delete(int transactionId, int accountId, CancellationToken cancellationToken = default)
    {
        var account = _repositoryManager.AccountRepository.GetById(accountId);
        if (account is null)
            throw new Exception("Account not found");
        var transaction =
            _repositoryManager.TransactionRepository.GetById(accountId);
        if (transaction is null)
            throw new Exception("Transaction not found");
        _repositoryManager.TransactionRepository.Delete(transaction);
        _repositoryManager.UnitOfWork.SaveChangesAsync(default);
    }
}