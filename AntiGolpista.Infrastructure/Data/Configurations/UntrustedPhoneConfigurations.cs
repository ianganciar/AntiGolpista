using AntiGolpista.Domain.Entities.PhoneNumbers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AntiGolpista.Infrastructure.Data.Configurations;
public class UntrustedPhoneConfigurations : IEntityTypeConfiguration<UntrustedPhoneNumber>
{
    public void Configure(EntityTypeBuilder<UntrustedPhoneNumber> builder)
    {
        builder.HasKey(upn => upn.Id);

        builder.OwnsOne(upn => upn.PhoneNumber, phoneNumber =>
        {
            phoneNumber.Property(p => p.Value)
                .HasColumnName("PhoneNumber")
                .IsRequired()
                .HasMaxLength(20);
        });

        builder.HasMany(upn => upn.FraudulentOcurrences)
            .WithOne(fo => fo.UntrustedPhoneNumber)
            .HasForeignKey(fo => fo.UntrustedPhoneNumberId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(upn => upn.SuspiciousOcurrences)
            .WithOne(so => so.UntrustedPhoneNumber)
            .HasForeignKey(so => so.UntrustedPhoneNumberId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}
