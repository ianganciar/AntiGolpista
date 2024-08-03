using AntiGolpista.Domain.Entities;

namespace AntiGolpista.Domain.Repositories;
public interface ISuspiciousPhoneNumberRepository
{
    Task<SuspiciousPhoneNumber> GetByIdAsync(int id);
    Task<List<SuspiciousPhoneNumber>> GetAllAsync();
    Task AddAsync(SuspiciousPhoneNumber fraudulentPhoneNumber);
    Task AddSuspicionCountAsync(int id);
    Task DeleteAsync(int id);
}