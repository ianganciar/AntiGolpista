using AntiGolpista.Domain.Entities.Companies;
using AntiGolpista.Domain.Entities.Occurrences;
using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Entities.PhoneNumbers;
public class TrustedPhoneNumber : BaseEntity
{
    public TrustedPhoneNumber(PhoneNumber phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }

    private TrustedPhoneNumber()
    {
        PhoneNumber = null!;
    }
    public PhoneNumber PhoneNumber { get; private set; } 
    public List<TrustedOccurrence> TrustedOccurrences { get; private set; } = [];
    public int CompanyId { get; private set; }
    public Company? Company { get; private set; }
}