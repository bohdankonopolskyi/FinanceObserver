using FinanceObserver.Application.Interfaces.Persistance;
using FinanceObserver.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class ClientRepository : Repository<Client>
{
    public ClientRepository(DbContext dbcontext) : base(dbcontext)
    {
    }
    
}