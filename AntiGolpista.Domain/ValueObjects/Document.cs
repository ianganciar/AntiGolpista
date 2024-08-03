using AntiGolpista.Domain.Enums;
using System.Text.RegularExpressions;

namespace AntiGolpista.Domain.ValueObjects;
public class Document
{
    private static readonly string CnpjRegexPattern = @"^\d{14}$";
    private static readonly string CpfRegexPattern = @"^\d{11}$";
    private static readonly Regex CnpjRegex = new Regex(CnpjRegexPattern, RegexOptions.Compiled);
    private static readonly Regex CpfRegex = new Regex(CpfRegexPattern, RegexOptions.Compiled);

    public Document(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Document cannot be null or empty.", nameof(value));
        }

        value = value.Replace(".", "").Replace("-", "").Replace("/", "");

        if (IsValidCnpj(value))
        {
            Value = value;
            Type = DocumentType.CNPJ;
        }
        else if (IsValidCpf(value))
        {
            Value = value;
            Type = DocumentType.CPF;
        }
        else
        {
            throw new ArgumentException("Invalid document format. It should be a valid CNPJ or CPF.", nameof(value));
        }
    }

    public string Value { get; }
    public DocumentType Type { get; }

    private bool IsValidCnpj(string value)
    {
        return CnpjRegex.IsMatch(value);
    }

    private bool IsValidCpf(string value)
    {
        return CpfRegex.IsMatch(value);
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj)
    {
        if (obj is Document other)
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