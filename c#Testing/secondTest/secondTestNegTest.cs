public class NegativeTestScenarios
{
    private readonly DecimalCalculator _calculator = new();
    private static IEnumerable AdditionTest()
    {
        yield return new TestCaseData(12m);
        yield return new TestCaseData(31m);
        yield return new TestCaseData(90m);
    }
 
    [TestCaseSource(nameof(AdditionTestData))]
    public void GeneratorAddition(decimal value1)
    {
        Assert.Throws<OverflowException>(()=>this._calculator.Enter(decimal.MaxValue).Plus(value1).Equals());
    }

    private static IEnumerable DivisionTest()
    {
        yield return new TestCaseData(16m);
        yield return new TestCaseData(30m);
        yield return new TestCaseData(80m);
    }

    [TestCaseSource(nameof(DivisionTest))]
    public void GeneratorDivision(decimal value1)
    {
        Assert.Throws<OverflowException>(()=>this._calculator.Enter(decimal.MaxValue).DivideBy(value1).Equals());
    }

    private static IEnumerable MultiplicationTest()
    {
        yield return new TestCaseData(3m);
        yield return new TestCaseData(5m);
        yield return new TestCaseData(60m);
    }

    [TestCaseSource(nameof(MultiplicationTest))]
    public void GeneratorMultiplication(decimal value1)
    {
        Assert.Throws<OverflowException>(()=>this._calculator.Enter(decimal.MaxValue).MultiplyBy(value1).Equals());
    }

    private static IEnumerable SubtractionTest()
    {
        yield return new TestCaseData(10m);
        yield return new TestCaseData(15m);
        yield return new TestCaseData(160m);
    }

    [TestCaseSource(nameof(SubtractionTest))]
    public void GeneratorDivision(decimal value1)
    {
        Assert.Throws<OverflowException>(()=>this._calculator.Enter(decimal.MaxValue).MinusBy(value1).Equals());
    }
}
