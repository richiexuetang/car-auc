using MediatR;

namespace CarAuc.BuildingBlocks.Core.CQRS;

public interface IQuery<out T> : IRequest<T>
    where T : notnull
{
}
