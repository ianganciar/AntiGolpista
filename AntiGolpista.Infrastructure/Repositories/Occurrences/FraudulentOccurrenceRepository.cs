using AntiGolpista.Domain.Entities.Occurrences;
using AntiGolpista.Domain.Repositories.Occurrences;
using AntiGolpista.Infrastructure.Data;

namespace AntiGolpista.Infrastructure.Repositories.Occurrences;
public class FraudulentOccurrenceRepository : IFraudulentOccurrenceRepository
{
    private readonly ApplicationDbContext _context;

    public FraudulentOccurrenceRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(int UntrustedPhoneNumberId, FraudulentOccurrence occurrence)
    {
        await _context.FraudulentOccurrences.AddAsync(occurrence);
    }
}
