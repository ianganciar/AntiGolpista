namespace AntiGolpista.Domain.Entities;
public class FraudulentOccurrence : BaseEntity
{
    public DateTime OccurrenceDate { get; private set; } = DateTime.Now;
    public int UntrustedPhoneNumberId { get; private set; }
    public UntrustedPhoneNumber? UntrustedPhoneNumber { get; private set; }
}
