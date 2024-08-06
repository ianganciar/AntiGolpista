using AntiGolpista.Domain.Entities.Companies;
using AntiGolpista.Domain.Entities.Occurrences;

namespace AntiGolpista.Domain.Entities.PhoneNumbers;
public class TrustedPhoneNumber(string phoneNumber)
{
    public string PhoneNumber { get; private set; } = phoneNumber;
    public List<TrustedOccurrence> TrustedOccurrences { get; private set; } = [];
    public int CompanyId { get; private set; }
    public Company? Company { get; private set; }
}