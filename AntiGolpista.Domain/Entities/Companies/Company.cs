using AntiGolpista.Domain.Entities.PhoneNumbers;
using AntiGolpista.Domain.Entities.Users;
using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Entities.Companies;
public class Company : BaseEntity
{
    public Name Name { get; private set; }
    public PhoneNumber SupportPhoneNumber { get; private set; }
    public Document Document { get; private set; }
    public Uri DocumentImageUrl { get; private set; }
    public Uri ProfileImageUrl { get; private set; }
    public Uri BannerImageUrl { get; private set; }
    public bool IsVerified { get; private set; } = false;
    public int UserId { get; private set; }
    public User? User { get; private set; }
    public List<TrustedPhoneNumber> TrustedPhonesNumbers { get; private set; } = [];
    public List<UntrustedPhoneNumber> UntrustedPhoneNumbers { get; private set; } = [];

    private Company()
    {
        Name = null!;
        SupportPhoneNumber = null!;
        Document = null!;
        DocumentImageUrl = null!;
        ProfileImageUrl = null!;
        BannerImageUrl = null!;
    }
    public Company(
        Name name,
        PhoneNumber supportPhoneNumber,
        Document document,
        Uri documentImageUrl,
        Uri profileImageUrl,
        Uri bannerImageUrl
        )
    {
        Name = name;
        SupportPhoneNumber = supportPhoneNumber;
        Document = document;
        DocumentImageUrl = documentImageUrl;
        ProfileImageUrl = profileImageUrl;
        BannerImageUrl = bannerImageUrl;
    }

    public void UpdateName(Name newName)
    {
        Name = newName;
    }


    public void UpdateSupportPhoneNumber(PhoneNumber newSupportPhoneNumber)
    {
        SupportPhoneNumber = newSupportPhoneNumber;
    }

    public void UpdateDocument(Document newDocument)
    {
        Document = newDocument;
    }

    public void UpdateDocumentImageUrl(Uri newDocumentImageUrl)
    {
        DocumentImageUrl = newDocumentImageUrl;
    }

    public void UpdateProfileImageUrl(Uri newProfileImageUrl)
    {
        ProfileImageUrl = newProfileImageUrl;
    }

    public void UpdateBannerImageUrl(Uri newBannerImageUrl)
    {
        BannerImageUrl = newBannerImageUrl;
    }

    public void UpdateIsVerified(bool isVerified)
    {
        IsVerified = isVerified;
    }
}