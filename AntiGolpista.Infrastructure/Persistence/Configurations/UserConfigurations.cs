using AntiGolpista.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AntiGolpista.Infrastructure.Persistence.Configurations;
public class UserConfigurations : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

        builder.OwnsOne(u => u.Name, name =>
        {
            name.Property(n => n.Value)
             .HasColumnName("Name")
             .IsRequired()
             .HasMaxLength(100);

        });

        builder.OwnsOne(u => u.Email, email =>
        {
            email.Property(e => e.Value)
            .HasColumnName("Email")
            .IsRequired();
        });

        builder.Property(u => u.PasswordHash)
           .IsRequired()
           .HasMaxLength(256);

        builder.OwnsOne(u => u.PhoneNumber, phone =>
        {
            phone.Property(p => p.Value)
                .HasColumnName("PhoneNumber")
                .IsRequired()
                .HasMaxLength(20);
        });

        builder.Property(u => u.Role)
             .IsRequired()
             .HasConversion<string>()
             .HasMaxLength(20);

    }
}
