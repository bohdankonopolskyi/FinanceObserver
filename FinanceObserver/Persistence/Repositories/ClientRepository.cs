using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class ClientRepository : Repository<Client>, IClientRepository
{
    public ClientRepository(DbContext dbcontext) : base(dbcontext)
    {
    }

    // public Task<Client?> GetByIdAsync(int id)
    // {
    //    return Task.FromResult(_dbcontext.Set<Client>().SingleOrDefault(x => x.Id == id));
    // }
}