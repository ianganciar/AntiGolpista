using System.Text.RegularExpressions;

namespace AntiGolpista.Domain.ValueObjects;

public class PhoneNumber
{
    private static readonly string PhoneNumberRegexPattern = @"^\+?[1-9]\d{1,14}$";
    private static readonly Regex PhoneNumberRegex = new Regex(PhoneNumberRegexPattern, RegexOptions.Compiled);

    public PhoneNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Phone number cannot be null or empty.", nameof(value));
        }

        if (!IsValid(value))
        {
            throw new ArgumentException("Invalid phone number format.", nameof(value));
        }

        Value = value;
    }

    public string Value { get; }

    private bool IsValid(string value)
    {
        return PhoneNumberRegex.IsMatch(value);
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj)
    {
        if (obj is PhoneNumber other)
        {
            return Value.Equals(other.Value, StringComparison.Ordinal);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode(StringComparison.Ordinal);
    }
}