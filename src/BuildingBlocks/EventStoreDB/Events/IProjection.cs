namespace CarAuc.BuildingBlocks.EventStoreDB.Events;

public interface IProjection
{
    void When(object @event);
}
