using CarAuc.BuildingBlocks.EventStoreDB.Events;
using MediatR;

namespace CarAuc.BuildingBlocks.EventStoreDB.Projections;

public interface IProjectionProcessor
{
    Task ProcessEventAsync<T>(StreamEvent<T> streamEvent, CancellationToken cancellationToken = default)
        where T : INotification;
}
