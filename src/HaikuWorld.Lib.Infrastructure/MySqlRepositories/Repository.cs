using HaikuWorld.Lib.Domain;

namespace HaikuWorld.Lib.Infrastructure.MySqlRepositories
{
    public sealed class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : notnull
        where TKey : notnull
    {
        public Repository()
        {
        }

        public ValueTask<TEntity?> Find(TKey key)
        {


            throw new NotImplementedException();
        }

        public ValueTask<IReadOnlyList<TEntity>> FindAll((string key, OrderType orderType) order, params (string key, object value, OperatorType operatorType)[] searchParams)
        {
            throw new NotImplementedException();
        }

        public ValueTask Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public ValueTask Update(TEntity entity, TKey id)
        {
            throw new NotImplementedException();
        }

        public ValueTask Delete(TKey id)
        {
            throw new NotImplementedException();
        }
    }
}
