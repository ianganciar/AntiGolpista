using AntiGolpista.Domain.Enums;
using AntiGolpista.Domain.Security.Cryptography;
using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Entities;
public class User : BaseEntity
{
    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public string PasswordHash { get; private set; }
    public PhoneNumber PhoneNumber { get; private set; }
    public Role Role { get; private set; }
    public List<Company> Companies { get; private set; } = [];

    private readonly IPasswordEncripter _passwordEncripter;

    public User(
        Name name,
        Email email,
        Password password,
        PhoneNumber phoneNumber,
        IPasswordEncripter passwordEncripter)
    {
        Name = name;
        Email = email;
        _passwordEncripter = passwordEncripter;
        PasswordHash = EncryptPassword(password.Value);
        PhoneNumber = phoneNumber;
    }

    public void UpdateName(Name newName)
    {
        Name = newName;
    }

    public void UpdateEmail(Email newEmail)
    {
        Email = newEmail;
    }

    public void UpdatePassword(Password newPassword)
    {
        PasswordHash = EncryptPassword(newPassword.Value);
    }

    public void UpdatePhoneNumber(PhoneNumber newPhoneNumber)
    {
        PhoneNumber = newPhoneNumber;
    }
    private string EncryptPassword(string password)
    {
        return _passwordEncripter.Encrypt(password);
    }
}