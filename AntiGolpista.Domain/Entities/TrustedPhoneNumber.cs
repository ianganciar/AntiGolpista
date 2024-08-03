namespace AntiGolpista.Domain.Entities;
public class TrustedPhoneNumber(string phoneNumber)
{
    public string PhoneNumber { get; private set; } = phoneNumber;
    public int QueryCount { get; private set; }
    public int CompanyId { get; private set; }
    public Company? Company { get; private set; }
}