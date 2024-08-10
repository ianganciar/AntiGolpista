using AntiGolpista.Domain.Entities.Companies;
using AntiGolpista.Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace AntiGolpista.Domain.Entities.Users;
// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; }= DateTime.Now;
    public Name? Name { get; set; }
    public List<Company> Companies { get; set; } = [];
    
}

