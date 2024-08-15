using AntiGolpista.Domain.Repositories;
using AntiGolpista.Domain.Repositories.Companies;
using AntiGolpista.Domain.Repositories.Occurrences;
using AntiGolpista.Domain.Repositories.PhoneNumbers;
using AntiGolpista.Domain.Repositories.Users;
using AntiGolpista.Infrastructure.Data;
using AntiGolpista.Infrastructure.Repositories.Companies;
using AntiGolpista.Infrastructure.Repositories.Occurrences;
using AntiGolpista.Infrastructure.Repositories.PhoneNumbers;
using AntiGolpista.Infrastructure.Repositories.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AntiGolpista.Infrastructure;
public static class InfrastructureModule
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddRepositories()
            .AddDbContext(configuration);            

        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddScoped<IFraudulentOccurrenceRepository, FraudulentOccurrenceRepository>();
        services.AddScoped<ISuspiciousOccurrenceRepository, SuspiciousOccurrenceRepository>();
        services.AddScoped<ITrustedOccurenceRepository, TrustedOccurrenceRepository>();
        services.AddScoped<ITrustedPhoneNumberRepository, TrustedPhoneNumberRepository>();
        services.AddScoped<IUntrustedPhoneNumberRepository, UntrustedPhoneNumberRepository>();
        services.AddScoped<IUserRepository, UserRepository>();        

        return services;
    }

    private static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

        return services;
    }
}
