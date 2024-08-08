using AntiGolpista.Domain.Entities.Companies;
using AntiGolpista.Domain.Entities.Occurrences;
using AntiGolpista.Domain.Entities.PhoneNumbers;
using AntiGolpista.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AntiGolpista.Infrastructure.Persistence;
public class AntiGolpistaDbContext(DbContextOptions<AntiGolpistaDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<TrustedPhoneNumber> TrustedPhoneNumbers { get; set; }
    public DbSet<UntrustedPhoneNumber> untrustedPhoneNumbers { get; set; }
    public DbSet<TrustedOccurrence> TrustedOccurrences { get; set; }
    public DbSet<SuspiciousOccurrence> SuspiciousOccurrences { get; set; }
    public DbSet<FraudulentOccurrence> FraudulentOccurrences { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AntiGolpistaDbContext).Assembly);
    }
}
