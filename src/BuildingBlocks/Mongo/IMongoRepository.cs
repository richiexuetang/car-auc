using CarAuc.BuildingBlocks.Core.Model;

namespace CarAuc.BuildingBlocks.Mongo;

public interface IMongoRepository<TEntity, in TId> : IRepository<TEntity, TId>
    where TEntity : class, IAggregate<TId>
{
}
