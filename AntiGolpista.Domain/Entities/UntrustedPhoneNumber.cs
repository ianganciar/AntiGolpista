using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Entities;
public class UntrustedPhoneNumber(PhoneNumber phoneNumber)
{
    public PhoneNumber PhoneNumber { get; private set; } = phoneNumber;
    public List<FraudulentOccurrence> FraudulentOcurrences { get; private set; } = [];
    public List<SuspiciousOccurrence> SuspiciousOcurrences { get; private set; } = [];
    public int CompanyId { get; private set; }
    public Company? Company { get; private set; }
}