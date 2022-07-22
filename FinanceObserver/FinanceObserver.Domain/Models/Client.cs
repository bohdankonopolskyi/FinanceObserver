namespace FinanceObserver.Domain.Models;

public class Client
{
    public int ClientId { get; set; }
    public string? Name { get; set; }
    public  ICollection<Account>? Accounts { get; set; }

   
}

