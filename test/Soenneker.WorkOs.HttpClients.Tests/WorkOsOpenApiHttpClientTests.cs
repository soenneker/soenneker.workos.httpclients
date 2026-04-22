using Soenneker.WorkOs.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.WorkOs.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class WorkOsOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IWorkOsOpenApiHttpClient _httpclient;

    public WorkOsOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IWorkOsOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
