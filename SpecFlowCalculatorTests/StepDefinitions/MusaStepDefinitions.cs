using NUnit.Framework;
using SpecFlowCalculatorTests.Support;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding, Scope(Tag = "Musa")]
    public sealed class MusaStepDefinitions
    {
        private readonly CalculatorContext _ctx;
        public MusaStepDefinitions(CalculatorContext ctx) => _ctx = ctx;

        [When(@"I have entered (.*), (.*) and (.*) into the calculator and press musa_current_intensity")]
        public void WhenMusaCurrent(double N0, double lambda0, double tau)
        {
            _ctx.LastResult = _ctx.Calculator.MusaCurrentFailureIntensity(N0, lambda0, tau);
        }

        [When(@"I have entered (.*), (.*) and (.*) into the calculator and press musa_expected_failures")]
        public void WhenMusaExpected(double N0, double lambda0, double tau)
        {
            _ctx.LastResult = _ctx.Calculator.MusaExpectedFailures(N0, lambda0, tau);
        }

        [Then(@"the musa result should be (.*)")]
        public void ThenTheMusaResultShouldBe(double expected)
        {
            Assert.That(_ctx.LastResult, Is.EqualTo(expected).Within(1e-6));
        }
    }
}
