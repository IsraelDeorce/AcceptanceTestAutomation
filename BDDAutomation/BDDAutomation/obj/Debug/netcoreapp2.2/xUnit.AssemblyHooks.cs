[assembly: global::Xunit.TestFramework("TechTalk.SpecFlow.xUnit.SpecFlowPlugin.XunitTestFrameworkWithAssemblyFixture", "TechTalk.SpecFlow.xUnit.SpecFlowPlugin")]
[assembly: global::TechTalk.SpecFlow.xUnit.SpecFlowPlugin.AssemblyFixture(typeof(global::BDDAutomation_XUnitAssemblyFixture))]

public class BDDAutomation_XUnitAssemblyFixture : global::System.IDisposable
{
    private readonly global::System.Reflection.Assembly _currentAssembly;

    public BDDAutomation_XUnitAssemblyFixture()
    {
        _currentAssembly = typeof(BDDAutomation_XUnitAssemblyFixture).Assembly;
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunStart(_currentAssembly);
    }

    public void Dispose()
    {
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunEnd(_currentAssembly);
    }
}
