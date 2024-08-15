using AntiGolpista.Domain.Entities.Occurrences;

namespace AntiGolpista.Domain.Repositories.Occurrences;
public interface ISuspiciousOccurrenceRepository
{
    Task AddAsync(int UntrustedPhoneNumberId, SuspiciousOccurrence occurrence);
}