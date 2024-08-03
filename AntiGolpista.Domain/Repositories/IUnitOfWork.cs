namespace AntiGolpista.Domain.Repositories;
public interface IUnitOfWork
{
    Task CommitAsync(CancellationToken cancellationToken);
}

