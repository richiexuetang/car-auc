using Ardalis.GuardClauses;
using CarAuc.BuildingBlocks.Web;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Polly;

namespace CarAuc.BuildingBlocks.Polly;

public static class GrpcRetry
{
    //ref: https://anthonygiretti.com/2020/03/31/grpc-asp-net-core-3-1-resiliency-with-polly/
    public static IHttpClientBuilder AddGrpcRetryPolicyHandler(this IHttpClientBuilder httpClientBuilder)
    {
        return httpClientBuilder.AddPolicyHandler((sp, _) =>
        {
            var options = sp.GetRequiredService<IConfiguration>().GetOptions<PolicyOptions>(nameof(PolicyOptions));

            Guard.Against.Null(options, nameof(options));

            return Policy
                .HandleResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode)
                .WaitAndRetryAsync(options.Retry.RetryCount,
                    retryAttempt => TimeSpan.FromSeconds(options.Retry.SleepDuration),
                    onRetry: (response, timeSpan, retryCount, context) =>
                    {
                        if (response?.Exception != null)
                        {
                            var loggerFactory = sp.GetRequiredService<ILoggerFactory>();
                            var logger = loggerFactory.CreateLogger("PollyGrpcRetryPoliciesLogger");

                            logger.LogError(response.Exception,
                                "Request failed with {StatusCode}. Waiting {TimeSpan} before next retry. Retry attempt {RetryCount}.",
                                response.Result.StatusCode,
                                timeSpan,
                                retryCount);
                        }
                    });
        });
    }
}
