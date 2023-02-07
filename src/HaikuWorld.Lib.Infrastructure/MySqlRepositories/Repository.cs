using Dapper;
using HaikuWorld.Lib.Domain;
using HaikuWorld.Lib.Shared.Configurations;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;

namespace HaikuWorld.Lib.Infrastructure.MySqlRepositories;

public sealed class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : notnull
        where TKey : notnull
{
    private readonly IOptionsSnapshot<MySqlConfigration> mySqlConfigration;

    public Repository(IOptionsSnapshot<MySqlConfigration> mySqlConfigration)
    {
        this.mySqlConfigration = mySqlConfigration;
    }

    public async ValueTask<TEntity?> Find(TKey key)
    {
        using var connection = new SqlConnection(mySqlConfigration.Value.ConnectionString);

        connection.Open();

        string sql = $"SELECT * FROM {nameof(TEntity)} WHERE ID = @{nameof(TKey)}";
        var param = new { TKey = key };

        TEntity? entity = await connection.QueryFirstOrDefaultAsync<TEntity?>(sql, param);

        return entity;
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
