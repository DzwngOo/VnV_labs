using NUnit.Framework;
using SpecFlowCalculatorTests.Support;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding, Scope(Tag = "QualityMetrics")]
    public sealed class QualityMetricsStepDefinitions
    {
        private readonly CalculatorContext _ctx;
        public QualityMetricsStepDefinitions(CalculatorContext ctx) => _ctx = ctx;

        [When(@"I enter (.*) defects and (.*) KSSI and press defect_density")]
        public void WhenDefectDensity(double defects, double kssi)
        {
            _ctx.LastResult = _ctx.Calculator.DefectDensity(defects, kssi);
        }

        [When(@"I enter previous SSI (.*), added (.*), reused (.*), modified (.*), deleted (.*) and press next_ssi")]
        public void WhenNextSsi(double prev, double added, double reused, double modified, double deleted)
        {
            _ctx.LastResult = _ctx.Calculator.NextReleaseSSI(prev, added, reused, modified, deleted);
        }

        [Then(@"the metrics result should be (.*)")]
        public void ThenMetricsResult(double expected)
        {
            Assert.That(_ctx.LastResult, Is.EqualTo(expected).Within(1e-6));
        }
    }
}
