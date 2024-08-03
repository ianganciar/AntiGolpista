using System.Text.RegularExpressions;

namespace AntiGolpista.Domain.ValueObjects;
public class Password
{
    private static readonly string PasswordRegexPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
    private static readonly Regex PasswordRegex = new Regex(PasswordRegexPattern, RegexOptions.Compiled);

    public Password(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Password cannot be null or empty.", nameof(value));
        }

        if (!IsValid(value))
        {
            throw new ArgumentException("Password must be at least 8 characters long and include a mix of upper and lower case letters, digits, and special characters.", nameof(value));
        }

        Value = value;
    }

    public string Value { get; }

    private bool IsValid(string value)
    {
        return PasswordRegex.IsMatch(value);
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj)
    {
        if (obj is Password other)
        {
            return Value.Equals(other.Value);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}