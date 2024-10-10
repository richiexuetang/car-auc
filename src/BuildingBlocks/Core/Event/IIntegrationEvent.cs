using MassTransit;

namespace CarAuc.BuildingBlocks.Core.Event;

[ExcludeFromTopology]
public interface IIntegrationEvent : IEvent
{
}
