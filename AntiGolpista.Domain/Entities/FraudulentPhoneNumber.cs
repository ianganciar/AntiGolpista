using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Entities;
public class FraudulentPhoneNumber(PhoneNumber phoneNumber)
{
    public PhoneNumber PhoneNumber { get; private set; } = phoneNumber;
    public int FraudCount { get; private set; }
    public int CompanyId { get; private set; }
    public Company? Company { get; private set; }
}