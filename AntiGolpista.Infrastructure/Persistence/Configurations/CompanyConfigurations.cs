using AntiGolpista.Domain.Entities.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AntiGolpista.Infrastructure.Persistence.Configurations;
public class CompanyConfigurations : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(c => c.Id);

        builder.OwnsOne(c => c.Name, name =>
        {
            name.Property(n => n.Value)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(100);
        });

        builder.OwnsOne(c => c.SupportPhoneNumber, phone =>
        {
            phone.Property(p => p.Value)
                .HasColumnName("SupportPhoneNumber")
                .IsRequired()
                .HasMaxLength(20);
        });

        builder.OwnsOne(c => c.Document, document =>
        {
            document.Property(d => d.Value)
                .HasColumnName("Document")
                .IsRequired()
                .HasMaxLength(50);
        });

        builder.Property(c => c.DocumentImageUrl)
           .HasColumnName("DocumentImageUrl")
           .IsRequired();

        builder.Property(c => c.ProfileImageUrl)
            .HasColumnName("ProfileImageUrl")
            .IsRequired();

        builder.Property(c => c.BannerImageUrl)
            .HasColumnName("BannerImageUrl")
            .IsRequired();

        builder.Property(c => c.IsVerified)
           .HasColumnName("IsVerified")
           .IsRequired()
           .HasDefaultValue(false);


        builder.HasOne(c => c.User)
            .WithMany(u => u.Companies)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.TrustedPhonesNumbers)
           .WithOne(tpn => tpn.Company)
           .HasForeignKey(t => t.CompanyId)
           .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.UntrustedPhoneNumbers)
            .WithOne(upn => upn.Company)
            .HasForeignKey(t => t.CompanyId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}
