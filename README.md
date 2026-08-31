[![](https://img.shields.io/nuget/v/soenneker.workos.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.workos.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.workos.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.workos.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.workos.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.workos.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.workos.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.workos.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.WorkOs.HttpClients

Provides a cached `HttpClient` configured with the WorkOS API base address and secret API key.

## Installation

```bash
dotnet add package Soenneker.WorkOs.HttpClients
```

## Configuration

```json
{
  "WorkOs": {
    "ApiKey": "sk_example_123456789"
  }
}
```

`WorkOs:ClientBaseUrl` can override the default `https://api.workos.com/` endpoint. `AuthHeaderName` and `AuthHeaderValueTemplate` are available for compatible gateways; the value template may contain `{token}`.

## Registration and usage

```csharp
using Soenneker.WorkOs.HttpClients.Abstract;
using Soenneker.WorkOs.HttpClients.Registrars;

services.AddWorkOsOpenApiHttpClientAsSingleton();

public sealed class WorkOsOrganizationService
{
    private readonly IWorkOsOpenApiHttpClient _clientProvider;

    public WorkOsOrganizationService(IWorkOsOpenApiHttpClient clientProvider)
    {
        _clientProvider = clientProvider;
    }

    public async Task<string> ListOrganizations(CancellationToken cancellationToken)
    {
        HttpClient client = await _clientProvider.Get(cancellationToken);
        return await client.GetStringAsync("organizations?limit=10", cancellationToken);
    }
}
```

Use `AddWorkOsOpenApiHttpClientAsScoped()` when the provider should follow a scope. Each provider owns its cached client and removes it when disposed.
