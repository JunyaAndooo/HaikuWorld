namespace HaikuWorld.Lib.Shared.Attributes.Validations
{
    public interface IValidationAttribute<T> where T : notnull
    {
        string ErrorMessage { get; }
        bool IsValid(T tvalue);
    }
}
