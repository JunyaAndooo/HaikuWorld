namespace HaikuWorld.Lib.Domain;

public interface IRepository<TEntity, TKey>
        where TEntity : notnull
        where TKey : notnull
{
    ValueTask<TEntity?> Find(TKey key);
    ValueTask<IReadOnlyList<TEntity>> FindAll((string key, OrderType orderType) order, params (string key, object value, OperatorType operatorType)[] searchParams);
    ValueTask Insert(TEntity entity);
    ValueTask Update(TEntity entity, TKey id);
    ValueTask Delete(TKey id);
}

public enum OrderType
{
    Asc,
    Desc,
}

public enum OperatorType
{
    Equal,
    NotEqual,
    Like,
    LessThan,
    LessThanOrEqual,
    GreaterThan,
    GreaterThanOrEqual,
}
