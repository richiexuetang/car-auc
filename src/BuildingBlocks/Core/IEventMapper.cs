using CarAuc.BuildingBlocks.Core.Event;

namespace CarAuc.BuildingBlocks.Core;

public interface IEventMapper
{
    IIntegrationEvent? MapToIntegrationEvent(IDomainEvent @event);
    IInternalCommand? MapToInternalCommand(IDomainEvent @event);
}
