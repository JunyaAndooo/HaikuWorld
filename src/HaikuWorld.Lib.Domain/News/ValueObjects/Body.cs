using HaikuWorld.Lib.Shared.Attributes.Validations;

namespace HaikuWorld.Lib.Domain.News.ValueObjects;

[StringLengthUpperLimit(500)]
public sealed record Body : ValueObject<string>
{
    public Body(string value) : base(value) { }
}
