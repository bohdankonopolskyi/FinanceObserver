namespace Contracts.DTO;

public class ClientDto
{
    public int ClientId { get; set; }
    public string? Name { get; set; }
    public  ICollection<AccountDto>? Accounts { get; set; }
}