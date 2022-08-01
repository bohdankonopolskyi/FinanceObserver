using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Domain.Models;
using Persistence.Data;

namespace Persistence.Repositories;

public class ClientRepository : Repository<Client>, IClientRepository
{
    public ClientRepository(FinanceObserverDbContext dbcontext) : base(dbcontext)
    {
    }

    public override Task<Client?> GetByIdAsync(int id)
    {
       return Task.FromResult(_dbcontext.Set<Client>().SingleOrDefault(x => x.Id == id));
    }
}