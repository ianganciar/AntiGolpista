using AntiGolpista.Domain.Entities;

namespace AntiGolpista.Domain.Repositories;
public interface IFraudulentPhoneNumberRepository
{
    Task<FraudulentPhoneNumber> GetByIdAsync(int id);
    Task<List<FraudulentPhoneNumber>> GetAllAsync();
    Task AddAsync(FraudulentPhoneNumber fraudulentPhoneNumber);
    Task AddFraudCountAsync(int id);
    Task DeleteAsync(int id);
}