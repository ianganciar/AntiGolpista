using AntiGolpista.Domain.Entities.PhonesNumbers;

namespace AntiGolpista.Domain.Entities.Occurrences;

public class SuspiciousOccurrence : BaseEntity
{
    public DateTime OccurrenceDate { get; private set; } = DateTime.Now;
    public int UntrustedPhoneNumberId { get; private set; }
    public UntrustedPhoneNumber? UntrustedPhoneNumber { get; private set; }

}