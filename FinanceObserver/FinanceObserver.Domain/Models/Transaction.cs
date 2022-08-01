namespace FinanceObserver.Domain.Models;

public class Transaction : BaseEntity
{
    public  string? Description { get; set; }
    public  decimal OperationAmount { get; set; }
    public int AccountId { get; set; }
    public  Account? Account { get; set; }
}