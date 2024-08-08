using AntiGolpista.Domain.Entities.PhoneNumbers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AntiGolpista.Infrastructure.Persistence.Configurations;
public class TrustedPhoneConfigurations : IEntityTypeConfiguration<TrustedPhoneNumber>
{
    public void Configure(EntityTypeBuilder<TrustedPhoneNumber> builder)
    {
        builder.HasKey(tpn => tpn.Id);

        builder.OwnsOne(tpn => tpn.PhoneNumber, phoneNumber =>
        {
            phoneNumber.Property(p => p.Value)
                .HasColumnName("PhoneNumber")
                .IsRequired()
                .HasMaxLength(20);
        });

        builder.HasMany(tpn => tpn.TrustedOccurrences)
           .WithOne(to => to.TrustedPhoneNumber)
           .HasForeignKey(to => to.TrustedPhoneNumberId)
           .OnDelete(DeleteBehavior.Restrict);
    }
}
