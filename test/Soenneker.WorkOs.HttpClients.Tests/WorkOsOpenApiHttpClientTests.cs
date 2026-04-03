using Soenneker.WorkOs.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.WorkOs.HttpClients.Tests;

[Collection("Collection")]
public sealed class WorkOsOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IWorkOsOpenApiHttpClient _httpclient;

    public WorkOsOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IWorkOsOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
