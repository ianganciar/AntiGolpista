using AntiGolpista.Domain.Entities.Users;
using AntiGolpista.Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace AntiGolpista.Domain.Repositories.Users;
public interface IUserRepository
{
    Task UpdateName(int id, Name name);    
    Task DeleteAsync(int id);
}