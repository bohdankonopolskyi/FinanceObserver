namespace FinanceObserver.Domain.Models;

public class Client : BaseEntity
{
    public string? Name { get; set; }
    public  ICollection<Account>? Accounts { get; set; }

   
}

