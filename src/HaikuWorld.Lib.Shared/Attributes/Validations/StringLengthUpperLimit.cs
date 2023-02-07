using System.ComponentModel.DataAnnotations;

namespace HaikuWorld.Lib.Shared.Attributes.Validations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
public sealed class StringLengthUpperLimit : ValidationAttribute
{
    private readonly int maxLength;

    public StringLengthUpperLimit(int maxLength)
    {
        this.maxLength = maxLength;
        ErrorMessage = $"タイトルに {maxLength} 以上の文字を入力することができません。";
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult(ErrorMessage);
        }

        if (((string)value).Length < maxLength)
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult(ErrorMessage);
        }
    }
}