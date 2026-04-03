using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.WorkOs.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.WorkOs.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class WorkOsOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="WorkOsOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddWorkOsOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IWorkOsOpenApiHttpClient, WorkOsOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="WorkOsOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddWorkOsOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IWorkOsOpenApiHttpClient, WorkOsOpenApiHttpClient>();

        return services;
    }
}
