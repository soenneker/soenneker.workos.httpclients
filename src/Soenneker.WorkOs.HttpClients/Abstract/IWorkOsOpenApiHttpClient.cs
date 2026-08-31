using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.WorkOs.HttpClients.Abstract;

/// <summary>
/// Provides a cached <see cref="HttpClient"/> configured for the WorkOS API.
/// </summary>
public interface IWorkOsOpenApiHttpClient : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the configured WorkOS API client.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The cached HTTP client.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
