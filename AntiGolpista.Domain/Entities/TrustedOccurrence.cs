namespace AntiGolpista.Domain.Entities;
public class TrustedOccurrence : BaseEntity
{
    public DateTime OccurrenceDate { get; private set; } = DateTime.Now;
    public int TrustedPhoneNumberId { get; private set; }
    public TrustedPhoneNumber? TrustedPhoneNumber { get; private set; }
}
