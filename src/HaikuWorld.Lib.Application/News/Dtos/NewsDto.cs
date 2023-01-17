using HaikuWorld.Lib.Domain.News.ValueObjects;

namespace HaikuWorld.Lib.Application.News.Dtos
{
    public record NewsDto(NewsId NewsId, Title Title, Body Body);
}
