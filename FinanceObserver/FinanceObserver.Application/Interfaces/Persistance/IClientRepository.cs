using System.Linq.Expressions;
using FinanceObserver.Domain.Models;

namespace FinanceObserver.Application.Interfaces.Persistance;

public interface IClientRepository
{
    Client GetById(int clientId);
    IQueryable<Client> GetAll();
    IQueryable<Client> Find(Expression<Func<Client, bool>> predicate);

    void Add(Client client);

    void Update(Client client);

    void Delete(Client client);
}