using AntiGolpista.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AntiGolpista.Infrastructure.Data.Configurations;
public class UserConfigurations : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.HasKey(u => u.Id);

        builder.OwnsOne(u => u.Name, name =>
        {
            name.Property(n => n.Value)
             .HasColumnName("Name")
             .IsRequired()
             .HasMaxLength(100);
        });
    }
}
