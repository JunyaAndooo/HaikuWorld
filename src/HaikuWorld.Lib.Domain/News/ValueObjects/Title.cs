using HaikuWorld.Lib.Shared.Attributes.Validations;

namespace HaikuWorld.Lib.Domain.News.ValueObjects;

[StringLengthUpperLimit(30)]
public sealed record Title : ValueObject<string>
{
    public Title(string value) : base(value) { }
}
