using AntiGolpista.Domain.Entities.PhoneNumbers;

namespace AntiGolpista.Domain.Repositories.PhoneNumbers;
public interface ITrustedPhoneNumberRepository
{
    Task<TrustedPhoneNumber?> GetByIdAsync(int id);
    Task<List<TrustedPhoneNumber>> GetAllAsync();
    Task AddAsync(TrustedPhoneNumber trustedPhoneNumber);
    Task DeleteAsync(int id);
}