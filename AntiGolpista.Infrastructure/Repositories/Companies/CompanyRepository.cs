using AntiGolpista.Domain.Entities.Companies;
using AntiGolpista.Domain.Repositories.Companies;
using AntiGolpista.Domain.ValueObjects;
using AntiGolpista.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AntiGolpista.Infrastructure.Repositories.Companies;
public class CompanyRepository : ICompanyRepository
{
    private readonly ApplicationDbContext _context;

    public CompanyRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Company company)
    {
      await _context.Companies.AddAsync(company);
    }

    public async Task DeleteAsync(int id)
    {
        var company = await _context.Companies.FindAsync(id);

        company?.Delete();
    }

    public async Task<List<Company>> GetAllAsync()
    {
        return await _context.Companies.AsNoTracking().ToListAsync();
    }

    public async Task<Company?> GetByIdAsync(int id)
    {
        return await _context.Companies.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Company?> GetByNameAsync(Name name)
    {
        return await _context.Companies.AsNoTracking().FirstOrDefaultAsync(x => x.Name == name);
    }

    public async Task UpdateBannerImageUrlAsync(int id, Uri newBannerImageUrl)
    {
        var company = await _context.Companies.FindAsync(id);
        company?.UpdateBannerImageUrl(newBannerImageUrl);
    }

    public async Task UpdateDocumentAsync(int id, Document newDocument)
    {
        var company = await _context.Companies.FindAsync(id);
        company?.UpdateDocument(newDocument);
    }

    public async Task UpdateDocumentImageUrlAsync(int id, Uri newDocumentImageUrl)
    {
        var company = await _context.Companies.FindAsync(id);
        company?.UpdateDocumentImageUrl(newDocumentImageUrl);
    }

    public async Task UpdateIsVerifiedAsync(int id, bool isVerified)
    {
        var company = await _context.Companies.FindAsync(id);
        company?.UpdateIsVerified(isVerified);
    }

    public async Task UpdateProfileImageUrlAsync(int id, Uri newProfileImageUrl)
    {
        var company = await _context.Companies.FindAsync(id); 
        company?.UpdateProfileImageUrl(newProfileImageUrl);
    }

    public async Task UpdateSupportPhoneNumberAsync(int id, PhoneNumber newSupportPhoneNumber)
    {
        var company = await _context.Companies.FindAsync(id);
        company?.UpdateSupportPhoneNumber(newSupportPhoneNumber);
    } 
}
