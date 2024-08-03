using AntiGolpista.Domain.Entities;

namespace AntiGolpista.Domain.Repositories;
public interface IUntrustedPhoneNumberRepository
{
    Task<UntrustedPhoneNumber> GetByIdAsync(int id);
    Task<List<UntrustedPhoneNumber>> GetAllAsync();
    Task AddAsync(UntrustedPhoneNumber untrustedPhoneNumber);
    Task DeleteAsync(int id);
}