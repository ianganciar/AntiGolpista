using AntiGolpista.Domain.Entities.Occurrences;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AntiGolpista.Infrastructure.Data.Configurations;
public class SuspiciousOccurrenceConfigurations : IEntityTypeConfiguration<SuspiciousOccurrence>
{
    public void Configure(EntityTypeBuilder<SuspiciousOccurrence> builder)
    {
        builder.HasKey(to => to.Id);

        builder.Property(to => to.OccurrenceDate)
            .IsRequired();
    }
}
