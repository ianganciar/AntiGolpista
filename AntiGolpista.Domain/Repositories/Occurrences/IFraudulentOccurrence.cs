using AntiGolpista.Domain.Entities.Occurrences;

namespace AntiGolpista.Domain.Repositories.Occurrences;
public interface IFraudulentOccurrence
{
    Task AddAsync(int UntrustedPhoneNumberId, FraudulentOccurrence occurrence);
}