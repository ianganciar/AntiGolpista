using AntiGolpista.Domain.Entities.Occurrences;
using AntiGolpista.Domain.Repositories.Occurrences;
using AntiGolpista.Infrastructure.Data;

namespace AntiGolpista.Infrastructure.Repositories.Occurrences;
public class TrustedOccurrenceRepository : ITrustedOccurenceRepository
{
    private readonly ApplicationDbContext _context;

    public TrustedOccurrenceRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(int TrustedPhoneNumberId, TrustedOccurrence occurrence)
    {
        await _context.TrustedOccurrences.AddAsync(occurrence);
    }
}
