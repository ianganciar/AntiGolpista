using AntiGolpista.Domain.Entities;

namespace AntiGolpista.Domain.Repositories;
public interface IFraudulentOccurrence
{
    Task AddAsync(int UntrustedPhoneNumberId, FraudulentOccurrence occurrence);
}