using Reqnroll;
using Smusdi.Testing;

namespace ServiceName.Testing;

[Binding]
public sealed class ApiHook(SmusdiServiceTestingSteps smusdiServiceTestingSteps)
{
    private readonly SmusdiServiceTestingSteps smusdiServiceTestingSteps = smusdiServiceTestingSteps;

    [BeforeScenario("api")]
    public Task InitializeAndStartService() => this.smusdiServiceTestingSteps.GivenTheServiceInitializedAndStarted();
}
