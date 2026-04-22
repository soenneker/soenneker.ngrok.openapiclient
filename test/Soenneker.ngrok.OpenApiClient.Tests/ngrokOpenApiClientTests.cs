using Soenneker.Tests.HostedUnit;

namespace Soenneker.ngrok.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ngrokOpenApiClientTests : HostedUnitTest
{
    public ngrokOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
