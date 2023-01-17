using HaikuWorld.Lib.Shared.Attributes.Validations;

namespace HaikuWorld.Lib.Domain.News.ValueObjects;

[LowerLimit<int>(0)]
public sealed record NewsId : ValueObject<int>
{
    public NewsId(int value) : base(value) { }
}
