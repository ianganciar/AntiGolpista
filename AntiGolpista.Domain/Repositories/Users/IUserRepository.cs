using AntiGolpista.Domain.Entities.Users;
using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Repositories.Users;
public interface IUserRepository
{
    Task<ApplicationUser?> GetByIdAsync(int id);
    Task<ApplicationUser?> GetByEmailAsync(Email email);
    Task<ApplicationUser?> GetByPhoneNumber(PhoneNumber phoneNumber);
    Task AddAsync(ApplicationUser user);
    Task UpdateNameAsync(int userId, Name newName);
    Task UpdateEmailAsync(int userId, Email newEmail);
    Task UpdatePasswordAsync(int userId, string newPasswordHash);
    Task UpdatePhoneNumberAsync(int userId, PhoneNumber newPhoneNumber);
    Task DeleteAsync(int id);
}