using System.ComponentModel.DataAnnotations;

namespace HaikuWorld.Lib.Shared.Attributes.Validations;

public sealed class LowerLimitAttribute<T> : ValidationAttribute
        where T : notnull, IComparable<T>
{
    private readonly T underValue;

    public LowerLimitAttribute(T underValue)
    {
        this.underValue = underValue;
        base.ErrorMessage = $"{underValue} より大きい値を指定してください。";
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        if (((T)value).CompareTo(underValue) <= 0)
        {
            return new ValidationResult(base.ErrorMessage);
        }

        return ValidationResult.Success;
    }
}
