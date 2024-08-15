using AntiGolpista.Domain.Entities.Occurrences;

namespace AntiGolpista.Domain.Repositories.Occurrences;
public interface ITrustedOccurenceRepository
{
    Task AddAsync(int TrustedPhoneNumberId, TrustedOccurrence occurrence);
}
