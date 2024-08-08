using AntiGolpista.Domain.Entities.Occurrences;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AntiGolpista.Infrastructure.Persistence.Configurations;
public class FraudulentOccurrenceConfigurations : IEntityTypeConfiguration<FraudulentOccurrence>
{
    public void Configure(EntityTypeBuilder<FraudulentOccurrence> builder)
    {
        builder.HasKey(to => to.Id);

        builder.Property(to => to.OccurrenceDate)
            .IsRequired();
    }
}
