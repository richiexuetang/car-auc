using Microsoft.AspNetCore.Routing;

namespace CarAuc.BuildingBlocks.Web;

public interface IMinimalEndpoint
{
    IEndpointRouteBuilder MapEndpoint(IEndpointRouteBuilder builder);
}
