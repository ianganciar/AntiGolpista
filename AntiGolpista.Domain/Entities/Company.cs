using AntiGolpista.Domain.Security.Cryptography;
using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Entities;
public class Company : BaseEntity
{
    public Name Name { get; private set; }
    public PhoneNumber SupportPhoneNumber { get; private set; }
    public Document Document { get; private set; }
    public Url DocumentImageUrl { get; private set; }
    public Url ProfileImageUrl { get; private set; }
    public Url BannerImageUrl { get; private set; }
    public bool IsVerified { get; private set; } = false;
    public int UserId { get; private set; }
    public User? User { get; private set; }
    public List<TrustedPhoneNumber> TrustedPhonesNumbers { get; private set; } = [];
    public List<UntrustedPhoneNumber> UntrustedPhoneNumbers { get; private set; } = [];
   
    public Company(
        Name name,
        PhoneNumber supportPhoneNumber,
        Document document,
        Url documentImageUrl,
        Url profileImageUrl,
        Url bannerImageUrl,
        IPasswordEncripter passwordEncripter)
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

    public void UpdateDocumentImageUrl(Url newDocumentImageUrl)
    {
        DocumentImageUrl = newDocumentImageUrl;
    }

    public void UpdateProfileImageUrl(Url newProfileImageUrl)
    {
        ProfileImageUrl = newProfileImageUrl;
    }

    public void UpdateBannerImageUrl(Url newBannerImageUrl)
    {
        BannerImageUrl = newBannerImageUrl;
    }

    public void UpdateIsVerified(bool isVerified)
    {
        IsVerified = isVerified;
    }
}