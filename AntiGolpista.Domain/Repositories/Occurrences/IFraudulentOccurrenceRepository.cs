using AntiGolpista.Domain.Entities.Occurrences;

namespace AntiGolpista.Domain.Repositories.Occurrences;
public interface IFraudulentOccurrenceRepository
{
    Task AddAsync(int UntrustedPhoneNumberId, FraudulentOccurrence occurrence);
}