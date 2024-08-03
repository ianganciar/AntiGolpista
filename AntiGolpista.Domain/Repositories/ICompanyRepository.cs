using AntiGolpista.Domain.Entities;
using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Repositories;
public interface ICompanyRepository
{
    Task<Company?> GetByIdAsync(int id);
    Task<Company?> GetByNameAsync(Name name);
    Task<List<Company>> GetAllAsync();
    Task AddAsync(Company company);
    Task UpdateSupportPhoneNumberAsync(int id, PhoneNumber newSupportPhoneNumber);
    Task UpdateDocumentAsync(int id, Document newDocument);
    Task UpdateDocumentImageUrlAsync(int id, Url newDocumentPictureUrl);
    Task UpdateProfileImageUrlAsync(int id, Url newProfilePictureUrl);
    Task UpdateBannerImageUrlAsync(int id, Url newBannerPictureUrl);
    Task UpdateIsVerifiedAsync(int id, bool isVerified);
    Task DeleteAsync(int id);
}