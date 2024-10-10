using Asp.Versioning.Builder;

namespace CarAuc.BuildingBlocks.Web;

public class EndpointConfig
{
    public const string BaseApiPath = "api/v{version:apiVersion}";
    public static ApiVersionSet VersionSet { get; private set; } = default!;
}
