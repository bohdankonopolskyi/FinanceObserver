namespace Contracts.DTO;

public class AccountDto
{
    public  int AccountId { get; set; }
    public  DateTime? DateCreated { get; set; }
    public string? Description { get; set; }
    public  decimal? Balance { get; set; }
    public int ClientId { get; set; }
}