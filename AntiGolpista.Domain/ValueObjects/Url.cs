using System.Text.RegularExpressions;

namespace AntiGolpista.Domain.ValueObjects;
public class Url
{
    private static readonly string UrlRegexPattern = @"^(https?|ftp):\/\/[^\s/$.?#].[^\s]*$";
    private static readonly Regex UrlRegex = new Regex(UrlRegexPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public Url(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("URL cannot be null or empty.", nameof(value));
        }

        value = value.Trim();

        if (!IsValid(value))
        {
            throw new ArgumentException("Invalid URL format.", nameof(value));
        }

        Value = value;
    }

    public string Value { get; }

    private bool IsValid(string value)
    {
        // Check if the value matches the URL pattern
        return UrlRegex.IsMatch(value);
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj)
    {
        if (obj is Url other)
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