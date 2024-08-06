using AntiGolpista.Domain.Entities.PhoneNumbers;

namespace AntiGolpista.Domain.Repositories.PhoneNumbers;
public interface ITrustedPhoneNumberRepository
{
    Task<TrustedPhoneNumber> GetByIdAsync(int id);
    Task<List<TrustedPhoneNumber>> GetAllAsync();
    Task AddAsync(TrustedPhoneNumber fraudulentPhoneNumber);
    Task AddQueryCountAsync(int id);
    Task DeleteAsync(int id);
}