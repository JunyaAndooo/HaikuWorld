namespace HaikuWorld.Lib.Shared.Attributes.Validations;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
public sealed class StringLengthUpperLimit : Attribute, IValidationAttribute<string>
{
    private readonly int maxLength;

    public StringLengthUpperLimit(int maxLength)
        => this.maxLength = maxLength;

    public string ErrorMessage => $"タイトルに {maxLength} 以上の文字を入力することができません。";
    public bool IsValid(string tvalue) => (tvalue.Length < maxLength);
}