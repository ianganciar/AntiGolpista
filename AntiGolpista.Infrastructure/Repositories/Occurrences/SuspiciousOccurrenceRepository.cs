using AntiGolpista.Domain.Entities.Occurrences;
using AntiGolpista.Domain.Repositories.Occurrences;
using AntiGolpista.Infrastructure.Data;

namespace AntiGolpista.Infrastructure.Repositories.Occurrences;
public class SuspiciousOccurrenceRepository : ISuspiciousOccurrenceRepository
{
    private readonly ApplicationDbContext _context;

    public SuspiciousOccurrenceRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(int UntrustedPhoneNumberId, SuspiciousOccurrence occurrence)
    {
        await _context.SuspiciousOccurrences.AddAsync(occurrence);
    }
}
