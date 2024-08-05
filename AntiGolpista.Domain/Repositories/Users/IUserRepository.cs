using AntiGolpista.Domain.Entities.Users;
using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Repositories.Users;
public interface IUserRepository
{
    Task<User?> GetByIdAsync(int id);
    Task<User?> GetByEmailAsync(Email email);
    Task<User?> GetByPhoneNumber(PhoneNumber phoneNumber);
    Task AddAsync(User user);
    Task UpdateNameAsync(int userId, Name newName);
    Task UpdateEmailAsync(int userId, Email newEmail);
    Task UpdatePasswordAsync(int userId, string newPasswordHash);
    Task UpdatePhoneNumberAsync(int userId, PhoneNumber newPhoneNumber);
    Task DeleteAsync(int id);
}