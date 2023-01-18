namespace HaikuWorld.Lib.Shared.Attributes.Validations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
public sealed class LowerLimit<T> : Attribute, IValidationAttribute<T>
        where T : notnull, IComparable<T>
{
    private readonly T underValue;

    public LowerLimit(T underValue)
        => this.underValue = underValue;

    public string ErrorMessage => $"{underValue} より大きい値を指定してください。";
    public bool IsValid(T tvalue) => (tvalue.CompareTo(underValue) > 0);
}

