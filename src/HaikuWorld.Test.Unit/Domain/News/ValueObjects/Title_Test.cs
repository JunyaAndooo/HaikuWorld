using HaikuWorld.Lib.Domain.News.ValueObjects;
using Xunit;

namespace HaikuWorld.Test.Unit.Domain.News.ValueObjects
{
    public class Title_Test
    {
        [Fact]
        public void タイトルが30文字を超えたらエラー()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new Title("123456789012345678901234567890");
            });
        }
    }
}
