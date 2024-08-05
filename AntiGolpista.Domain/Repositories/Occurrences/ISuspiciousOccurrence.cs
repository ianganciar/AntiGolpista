using AntiGolpista.Domain.Entities.Occurrences;

namespace AntiGolpista.Domain.Repositories.Occurrences;
public interface ISuspiciousOccurrence
{
    Task AddAsync(int UntrustedPhoneNumberId, SuspiciousOccurrence occurrence);
}