using CarAuc.BuildingBlocks.Core.Event;
using MediatR;

namespace CarAuc.BuildingBlocks.EventStoreDB.Events;

public interface IEventHandler<in TEvent> : INotificationHandler<TEvent>
    where TEvent : IEvent
{
}
