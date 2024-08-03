using System.Text.RegularExpressions;

namespace AntiGolpista.Domain.ValueObjects;
public class Email
{
    private static readonly string EmailRegexPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
    private static readonly Regex EmailRegex = new Regex(EmailRegexPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Email cannot be null or empty.", nameof(value));
        }

        if (!IsValid(value))
        {
            throw new ArgumentException("Invalid email format.", nameof(value));
        }

        Value = value;
    }

    public string Value { get; }

    private bool IsValid(string value)
    {
        return EmailRegex.IsMatch(value);
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj)
    {
        if (obj is Email other)
        {
            return Value.Equals(other.Value, StringComparison.OrdinalIgnoreCase);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode(StringComparison.OrdinalIgnoreCase);
    }
}