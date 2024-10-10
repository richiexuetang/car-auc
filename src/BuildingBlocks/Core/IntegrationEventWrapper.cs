using CarAuc.BuildingBlocks.Core.Event;

namespace CarAuc.BuildingBlocks.Core;

public record IntegrationEventWrapper<TDomainEventType>(TDomainEventType DomainEvent) : IIntegrationEvent
    where TDomainEventType : IDomainEvent;
