using CarAuc.BuildingBlocks.Core.Event;
using CarAuc.BuildingBlocks.Core.Model;

namespace CarAuc.BuildingBlocks.EventStoreDB.Events
{
    public interface IAggregateEventSourcing : IProjection, IEntity
    {
        IReadOnlyList<IDomainEvent> DomainEvents { get; }
        IDomainEvent[] ClearDomainEvents();
    }

    public interface IAggregateEventSourcing<T> : IAggregateEventSourcing, IEntity<T>
    {
    }
}
