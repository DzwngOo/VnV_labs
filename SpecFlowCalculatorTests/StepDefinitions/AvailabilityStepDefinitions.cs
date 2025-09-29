using NUnit.Framework;
using SpecFlowCalculatorTests.Support;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding, Scope(Tag = "Availability")]
    public sealed class AvailabilityStepDefinitions
    {
        private readonly CalculatorContext _ctx;
        public AvailabilityStepDefinitions(CalculatorContext ctx) => _ctx = ctx;

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIEnterAndPressMTBF(double mttf, double mttr)
        {
            _ctx.LastResult = _ctx.Calculator.MTBF(mttf, mttr);
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIEnterAndPressAvailability(double mttf, double mttr)
        {
            _ctx.LastResult = _ctx.Calculator.Availability(mttf, mttr);
        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double expected)
        {
            // Tolerance to avoid flaky floating point comparisons
            Assert.That(_ctx.LastResult, Is.EqualTo(expected).Within(1e-9));
        }
    }
}
