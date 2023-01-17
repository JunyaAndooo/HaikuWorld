using HaikuWorld.Lib.Shared.Attributes.Validations;
using System.Reflection;

namespace HaikuWorld.Lib.Domain;

public abstract record ValueObject<T> where T : notnull
{
    protected ValueObject(T value)
    {
        var attrs = typeof(T).GetCustomAttributes();
        foreach (var attr in attrs)
        {
            if (attr is IValidationAttribute<T> valid)
            {
                if (!valid.IsValid(value))
                {
                    // TODO ここの第一引数は、ValueObjectを継承したもの
                    //throw new ArgumentInvalidException<T, typeof(attr), T>($"{valid.ErrorMessage} 実際の値：'{value}'");
                }
            }
        }

        Value = value;
    }

    public T Value { get; }
}