using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Entities;
public class SuspiciousPhoneNumber(PhoneNumber phoneNumber)
{
    public PhoneNumber PhoneNumber { get; private set; } = phoneNumber;
    public int SuspicionCount { get; private set; } 
    public int CompanyId { get; private set; }
    public Company? Company { get; private set; }
}