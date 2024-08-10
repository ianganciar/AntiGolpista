using AntiGolpista.Domain.Entities.Companies;
using AntiGolpista.Domain.Entities.Occurrences;
using AntiGolpista.Domain.Entities.PhoneNumbers;
using AntiGolpista.Domain.Entities.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AntiGolpista.Infrastructure.Data;
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Company> Companies { get; set; }
    public DbSet<TrustedPhoneNumber> TrustedPhoneNumbers { get; set; }
    public DbSet<UntrustedPhoneNumber> UntrustedPhoneNumbers { get; set; }
    public DbSet<TrustedOccurrence> TrustedOccurrences { get; set; }
    public DbSet<SuspiciousOccurrence> SuspiciousOccurrences { get; set; }
    public DbSet<FraudulentOccurrence> FraudulentOccurrences { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
