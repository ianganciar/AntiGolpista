using AntiGolpista.Domain.Entities.PhoneNumbers;
using AntiGolpista.Domain.Repositories.PhoneNumbers;
using AntiGolpista.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AntiGolpista.Infrastructure.Repositories.PhoneNumbers;
public class TrustedPhoneNumberRepository : ITrustedPhoneNumberRepository
{
    private readonly ApplicationDbContext _context;

    public TrustedPhoneNumberRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TrustedPhoneNumber trustedPhoneNumber)
    {
       await _context.TrustedPhoneNumbers.AddAsync(trustedPhoneNumber);
    }

    public async Task DeleteAsync(int id)
    {
        var trustedPhoneNumber = await _context.TrustedPhoneNumbers.FindAsync(id);
        trustedPhoneNumber?.Delete();
    }

    public async Task<List<TrustedPhoneNumber>> GetAllAsync()
    {
        return await _context.TrustedPhoneNumbers.AsNoTracking().ToListAsync();
    }

    public async Task<TrustedPhoneNumber?> GetByIdAsync(int id)
    {
        return await _context.TrustedPhoneNumbers.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }
}
