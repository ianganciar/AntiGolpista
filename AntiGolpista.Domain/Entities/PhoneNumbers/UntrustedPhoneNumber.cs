using AntiGolpista.Domain.Entities.Companies;
using AntiGolpista.Domain.Entities.Occurrences;
using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Entities.PhonesNumbers;
public class UntrustedPhoneNumber(PhoneNumber phoneNumber)
{
    public PhoneNumber PhoneNumber { get; private set; } = phoneNumber;
    public List<FraudulentOccurrence> FraudulentOcurrences { get; private set; } = [];
    public List<SuspiciousOccurrence> SuspiciousOcurrences { get; private set; } = [];
    public int CompanyId { get; private set; }
    public Company? Company { get; private set; }
}