using NUnit.Framework;
using SpecFlowCalculatorTests.Support;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding, Scope(Tag = "Addition")]
    public sealed class UsingCalculatorStepDefinitions
    {
        private readonly CalculatorContext _ctx;
        public UsingCalculatorStepDefinitions(CalculatorContext ctx) => _ctx = ctx;

        // [Given(@"I have a calculator")]
        // public void GivenIHaveACalculator()
        // {
        //     // Context pre-creates the Calculator; no-op here.
        // }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _ctx.LastResult = _ctx.Calculator.Add(p0, p1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double expected)
        {
            Assert.That(_ctx.LastResult, Is.EqualTo(expected));
        }
    }
}
