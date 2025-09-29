using SpecFlowCalculatorTests.Support;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    // No Scope attribute here -> available to ALL scenarios/tags
    [Binding]
    public sealed class CommonSteps
    {
        private readonly CalculatorContext _ctx;
        public CommonSteps(CalculatorContext ctx) => _ctx = ctx;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            // _ctx.Calculator is constructed in CalculatorContext; nothing to do.
        }
    }
}
