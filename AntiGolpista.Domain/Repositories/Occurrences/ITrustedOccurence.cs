using AntiGolpista.Domain.Entities.Occurrences;

namespace AntiGolpista.Domain.Repositories.Occurrences;
public interface ITrustedOccurence
{
    Task AddAsync(int TrustedPhoneNumberId, TrustedOccurrence occurrence);
}
