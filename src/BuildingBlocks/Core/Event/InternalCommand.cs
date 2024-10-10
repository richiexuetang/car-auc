
using CarAuc.BuildingBlocks.Core.CQRS;

namespace CarAuc.BuildingBlocks.Core.Event;

public record InternalCommand : IInternalCommand, ICommand;
