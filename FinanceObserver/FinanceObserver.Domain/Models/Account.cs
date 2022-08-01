namespace FinanceObserver.Domain.Models;

public  class Account : BaseEntity
{
    public string? Description { get; set; }
    public  decimal? Balance { get; set; }
    public string? CurrencyCode { get; set; }
    public int ClientId { get; set; }
    public Client? Client { get; set; }
}