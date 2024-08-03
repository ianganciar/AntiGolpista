using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AntiGolpista.Domain.ValueObjects;
public class Name
{
    private static readonly string NameRegexPattern = @"^[a-zA-Z0-9\s]+$";
    private static readonly Regex NameRegex = new Regex(NameRegexPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public Name(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Name cannot be null or contain only whitespace.", nameof(value));
        }

        value = value.Trim();

        if (!IsValid(value))
        {
            throw new ArgumentException("Invalid name format. It can contain letters, numbers, and spaces only.", nameof(value));
        }

        Value = value;
    }

    public string Value { get; }

    private bool IsValid(string value)
    {
        // Check if the value matches the allowed pattern
        return NameRegex.IsMatch(value);
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj)
    {
        if (obj is Name other)
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