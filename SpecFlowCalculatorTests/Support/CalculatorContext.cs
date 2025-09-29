namespace SpecFlowCalculatorTests.Support
{
    public class CalculatorContext
    {
        public global::Calculator Calculator { get; } = new global::Calculator();
        public double LastResult { get; set; }
    }
}
