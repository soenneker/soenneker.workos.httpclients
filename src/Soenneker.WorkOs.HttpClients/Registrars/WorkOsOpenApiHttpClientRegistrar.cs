using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.WorkOs.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.WorkOs.HttpClients.Registrars;

/// <summary>
/// Registers the WorkOS API HTTP client provider.
/// </summary>
public static class WorkOsOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds the WorkOS HTTP client provider as a singleton service.
    /// </summary>
    public static IServiceCollection AddWorkOsOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IWorkOsOpenApiHttpClient, WorkOsOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds the WorkOS HTTP client provider as a scoped service.
    /// </summary>
    public static IServiceCollection AddWorkOsOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IWorkOsOpenApiHttpClient, WorkOsOpenApiHttpClient>();

        return services;
    }
}
