using AntiGolpista.Domain.Entities.Users;
using AntiGolpista.Domain.Repositories.Users;
using AntiGolpista.Domain.ValueObjects;
using AntiGolpista.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AntiGolpista.Infrastructure.Repositories.Users;
public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task DeleteAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user != null)
        {
            user.IsActive = false;
        }
    }

    public async Task UpdateName(int id, Name name)
    {
        var user = await _context.Users.FindAsync(id);
        if (user != null)
        {
            user.Name = name;
        }
    }
}
