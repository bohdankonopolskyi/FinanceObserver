namespace FinanceObserver.Domain.Models;

public class Transaction
{
    public int TransactionId { get; set; }
    public  string? Description { get; set; }
    public  decimal OperationAmount { get; set; }
    public DateTime OperationDateTime { get; set; }
    public int AccountId { get; set; }
    public  Account? Account { get; set; }
}