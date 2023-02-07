using HaikuWorld.Lib.Shared.Attributes.Validations;

namespace HaikuWorld.Lib.Domain.News.ValueObjects;

[LowerLimit<int>(MinValue)]
public sealed record NewsId : ValueObject<int>
{
    public const int MinValue = 0;

    public NewsId(int value) : base(value) { }
}
