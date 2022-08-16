using AutoMapper;
using FinanceObserver.Application.Interfaces.Persistance;

namespace FinanceObserver.Application.Services;

public abstract class ServiceBase<TEntity> where TEntity : class
{
protected IRepositoryManager _repositoryManager;
protected IMapper _mapper;
protected ServiceBase(IRepositoryManager repositoryManager, IMapper mapper)
{
    _repositoryManager = repositoryManager;
    _mapper = mapper;
}
}