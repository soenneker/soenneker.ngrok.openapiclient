using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.ngrok.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class ngrokOpenApiClientTests : FixturedUnitTest
{
    public ngrokOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
