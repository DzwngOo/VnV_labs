using NUnit.Framework;
using SpecFlowCalculatorTests.Support;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding, Scope(Tag = "Factorial")]
    public sealed class FactorialStepDefinitions
    {
        private readonly CalculatorContext _ctx;
        public FactorialStepDefinitions(CalculatorContext ctx) => _ctx = ctx;

        private double _n;

        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIEnterNAndPressFactorial(double n)
        {
            _n = n;
            _ctx.LastResult = _ctx.Calculator.Factorial(n);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double expected)
        {
            Assert.That(_ctx.LastResult, Is.EqualTo(expected));
        }
    }
}
