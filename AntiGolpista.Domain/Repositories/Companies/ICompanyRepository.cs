using AntiGolpista.Domain.Entities.Companies;
using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Repositories.Companies;
public interface ICompanyRepository
{
    Task<Company?> GetByIdAsync(int id);
    Task<Company?> GetByNameAsync(Name name);
    Task<List<Company>> GetAllAsync();
    Task AddAsync(Company company);
    Task UpdateSupportPhoneNumberAsync(int id, PhoneNumber newSupportPhoneNumber);
    Task UpdateDocumentAsync(int id, Document newDocument);
    Task UpdateDocumentImageUrlAsync(int id, Uri newDocumentPictureUrl);
    Task UpdateProfileImageUrlAsync(int id, Uri newProfilePictureUrl);
    Task UpdateBannerImageUrlAsync(int id, Uri newBannerPictureUrl);
    Task UpdateIsVerifiedAsync(int id, bool isVerified);
    Task DeleteAsync(int id);
}