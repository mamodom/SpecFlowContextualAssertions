using FluentAssertions;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecflowContextualAssertions
{
    [Binding]
    public class Steps
    {
        [StepDefinition("passing assertion")]
        public void PassingAssertion() =>
            true.Should().BeTrue();

        [StepDefinition("failling assertion")]
        public void FaillingAssertion() =>
            true.Should().BeFalse();

        [AfterStep]
        public void MarkSetupAssertionExceptionsAsInconclusive()
        {
            if (ScenarioContext.Current.TestError is AssertionException &&
                ScenarioContext.Current.CurrentScenarioBlock == ScenarioBlock.Given)
                Assert.Inconclusive(ScenarioContext.Current.TestError.Message);
        }
    }
}
