using HaikuWorld.Lib.Application.News.Dtos;
using HaikuWorld.Lib.Domain;
using HaikuWorld.Lib.Domain.News;
using HaikuWorld.Lib.Domain.News.ValueObjects;

namespace HaikuWorld.Lib.Application.News
{
    public sealed class NewsListInteractor : IUseCase<EmptyRequest, NewsListResponse>
    {
        private readonly IRepository<NewsEntity, NewsId> newsRepository;

        public NewsListInteractor(IRepository<NewsEntity, NewsId> newsRepository)
        {
            this.newsRepository = newsRepository;
        }

        public async ValueTask<NewsListResponse> Handle(EmptyRequest _)
        {
            DateTime now = DateTime.Now;

            IReadOnlyList<NewsEntity> newses = await newsRepository.FindAll(
                (nameof(NewsEntity.NewsId), OrderType.Desc),
                (nameof(NewsEntity.Enabled), true, OperatorType.Equal),
                (nameof(NewsEntity.ReleaseTime), now, OperatorType.GreaterThanOrEqual),
                (nameof(NewsEntity.CloseTime), now, OperatorType.LessThan)
            );

            return new NewsListResponse(
                newses.Select(n => new NewsDto(n.NewsId!, n.Title, n.Body))
            );
        }
    }
}
