using System.Collections;
using Calculators;
namespace SecondTest;

[TestFixture]
public class PositiveTestScenarios
{
    private DecimalCalculator Calculator { get; } = new DecimalCalculator();

    [TestCase(5.0, 7.0, 12.0)]
    [TestCase(2.0, -3.0, -1.0)]
    public void Addition(decimal value1, decimal value2, decimal expected)
    {
        var actual = Calculator.Reset().Enter(value1).Plus(value2).Equals();
        Assert.That(actual, Is.EqualTo(expected));
    }

    private static IEnumerable AdditionTestData()
    {
        yield return new TestCaseData(1m, 1m, 2m);
        yield return new TestCaseData(1m, 2m, 3m);
        yield return new TestCaseData(-1m, -1m, -2m);
    }

    [TestCaseSource(nameof(AdditionTestData))]
    public void GeneratorAddition(decimal value1, decimal value2, decimal expected)
    {
        var actual = Calculator.Reset().Enter(value1).Plus(value2).Equals();
        Assert.That(actual, Is.EqualTo(expected));
    }
}

