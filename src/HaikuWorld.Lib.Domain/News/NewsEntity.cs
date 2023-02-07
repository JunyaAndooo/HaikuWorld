using HaikuWorld.Lib.Domain.News.ValueObjects;

namespace HaikuWorld.Lib.Domain.News;

public sealed record NewsEntity
{
    public NewsEntity(NewsId? newsId, Title title, Body body, DateTime createdAt, DateTime updatedAt, bool enabled, DateTime releaseTime, DateTime closeTime)
    {
        if (ReleaseTime > CloseTime)
        {
            throw new Exception($"公開日時と終了日時の指定が正しくありません。 公開日時：{ReleaseTime}, 終了日時：{CloseTime}");
        }

        (NewsId, Title, Body, CreatedAt, UpdatedAt, Enabled, ReleaseTime, CloseTime) = (newsId, title, body, createdAt, updatedAt, enabled, releaseTime, closeTime);
    }

    public NewsId? NewsId { get; }
    public Title Title { get; }
    public Body Body { get; }
    public DateTime CreatedAt { get; }
    public DateTime UpdatedAt { get; }
    public bool Enabled { get; }
    public DateTime ReleaseTime { get; }
    public DateTime CloseTime { get; }
}
