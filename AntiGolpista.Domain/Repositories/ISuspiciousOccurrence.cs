using AntiGolpista.Domain.Entities;

namespace AntiGolpista.Domain.Repositories;
public interface ISuspiciousOccurrence
{
    Task AddAsync(int UntrustedPhoneNumberId, SuspiciousOccurrence occurrence);
}