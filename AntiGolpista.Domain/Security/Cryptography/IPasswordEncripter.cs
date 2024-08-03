using AntiGolpista.Domain.ValueObjects;

namespace AntiGolpista.Domain.Security.Cryptography;

public interface IPasswordEncripter
{
    public string Encrypt(string password);
    public bool IsInvalid(string password, string userPassoword);
}