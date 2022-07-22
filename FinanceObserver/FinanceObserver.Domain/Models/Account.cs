namespace FinanceObserver.Domain.Models;

public  class Account
{
    public  int AccountId { get; set; }
    public  DateTime? DateCreated { get; set; }
    public string? Description { get; set; }
    public  decimal? Balance { get; set; }
    public string? CurrencyCode { get; set; }
    public int ClientId { get; set; }
    public Client? Client { get; set; }
}