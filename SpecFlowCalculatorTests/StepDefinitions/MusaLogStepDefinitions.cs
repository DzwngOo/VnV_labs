using NUnit.Framework;
using SpecFlowCalculatorTests.Support;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding, Scope(Tag = "MusaLog")]
    public sealed class MusaLogStepDefinitions
    {
        private readonly CalculatorContext _ctx;
        public MusaLogStepDefinitions(CalculatorContext ctx) => _ctx = ctx;

        [When(@"I enter lambda0 (.*), theta (.*), time (.*) and press musa_log_lambda")]
        public void WhenMusaLogLambda(double lambda0, double theta, double x)
        {
            _ctx.LastResult = _ctx.Calculator.MusaLogCurrentFailureIntensity(lambda0, theta, x);
        }

        [When(@"I enter lambda0 (.*), theta (.*), time (.*) and press musa_log_mu")]
        public void WhenMusaLogMu(double lambda0, double theta, double x)
        {
            _ctx.LastResult = _ctx.Calculator.MusaLogExpectedFailures(lambda0, theta, x);
        }

        [Then(@"the reliability result should be (.*)")]
        public void ThenReliabilityResult(double expected)
        {
            Assert.That(_ctx.LastResult, Is.EqualTo(expected).Within(1e-6));
        }
    }
}
