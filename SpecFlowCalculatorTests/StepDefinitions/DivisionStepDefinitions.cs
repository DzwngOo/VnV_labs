using NUnit.Framework;
using SpecFlowCalculatorTests.Support;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class DivisionStepDefinitions
    {
        private readonly CalculatorContext _ctx;
        public DivisionStepDefinitions(CalculatorContext ctx) => _ctx = ctx;

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double a, double b)
        {
            _ctx.LastResult = _ctx.Calculator.DivideAcceptance(a, b);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double expected)
        {
            Assert.That(_ctx.LastResult, Is.EqualTo(expected));
        }

        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositive_Infinity()
        {
            Assert.That(double.IsPositiveInfinity(_ctx.LastResult), Is.True);
        }
    }
}
