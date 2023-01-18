using HaikuWorld.Lib.Application.News.Dtos;

namespace HaikuWorld.Lib.Application.News;

public sealed record NewsListResponse(
    IEnumerable<NewsDto> Newses
) : IResponse;
