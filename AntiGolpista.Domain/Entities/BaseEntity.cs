namespace AntiGolpista.Domain.Entities;
public abstract class BaseEntity
{
    public int Id { get; private set; }
    public bool IsActive { get; private set; } = true;
    public DateTime CreatedAt { get; private set; } = DateTime.Now;

    public void Delete()
    {
        IsActive = false;
    }
}