using HaikuWorld.Lib.Shared.Attributes.Validations;

namespace HaikuWorld.Lib.Shared.Exceptions;

public class ArgumentInvalidException<TObject, TValidation, T> : Exception
        where TObject : notnull
        where TValidation : IValidationAttribute<T>
        where T : notnull
{
    public ArgumentInvalidException(string? message) : base(message) { }
}
