using AntiGolpista.Domain.Entities.PhoneNumbers;
using AntiGolpista.Domain.Repositories.PhoneNumbers;
using AntiGolpista.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiGolpista.Infrastructure.Repositories.PhoneNumbers;
public class UntrustedPhoneNumberRepository : IUntrustedPhoneNumberRepository
{
    private readonly ApplicationDbContext _context;

    public UntrustedPhoneNumberRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task AddAsync(UntrustedPhoneNumber untrustedPhoneNumber)
    {
        await _context.UntrustedPhoneNumbers.AddAsync(untrustedPhoneNumber);
    }

    public async Task DeleteAsync(int id)
    {
        var untrustedPhoneNumber = await _context.UntrustedPhoneNumbers.FindAsync(id);
        untrustedPhoneNumber?.Delete();
    }

    public async Task<List<UntrustedPhoneNumber>> GetAllAsync()
    {
        return await _context.UntrustedPhoneNumbers.ToListAsync();
    }

    public async Task<UntrustedPhoneNumber?> GetByIdAsync(int id)
    {
        return await _context.UntrustedPhoneNumbers.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }
}
