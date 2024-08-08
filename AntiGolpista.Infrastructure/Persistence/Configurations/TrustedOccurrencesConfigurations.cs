using AntiGolpista.Domain.Entities.Occurrences;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AntiGolpista.Infrastructure.Persistence.Configurations;
public class TrustedOccurrencesConfigurations : IEntityTypeConfiguration<TrustedOccurrence>
{
    public void Configure(EntityTypeBuilder<TrustedOccurrence> builder)
    {
        builder.HasKey(to => to.Id);

        builder.Property(to => to.OccurrenceDate)
            .IsRequired();
    }
}
