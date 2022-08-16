namespace FinanceObserver.Domain.Models;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime DateOfCreation { get; set; }

    protected BaseEntity()
    {
        DateOfCreation = DateTime.UtcNow;
    }
}