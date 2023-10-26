using System.Collections;
using Calculators;
namespace secondTestNegTests;
public class NegTest
{
    private readonly SimpleCalculator _calculator = new();
    
    //Addition by Max Value
    private static IEnumerable AdditionTestData()
    {
        yield return new TestCaseData(2m);
        yield return new TestCaseData(3m);
        yield return new TestCaseData(30m);

    }

    [TestCaseSource(nameof(AdditionTestData))]
    public void GeneratorDataDrivenAddition(decimal value1)
    {
        // Assert
        Assert.Throws<OverflowException>(()=>this._calculator.Enter(decimal.MaxValue).Plus(value1));
    }

//----------------------------------------------------------------------------------------------

    // Addition by Min Value 
       private static IEnumerable AdditionTestByMinValueData()
    {
        yield return new TestCaseData(-2.0m);
        yield return new TestCaseData(-3.0m);
        yield return new TestCaseData(-1.0m);
    }

    // Addition by Min Value
    [TestCaseSource(nameof(AdditionTestByMinValueData))]
    public void GeneratorDataDrivenAdditionByMinValue(decimal value1)
    {
        // Assert
        Assert.Throws<OverflowException>(()=>this._calculator.Enter(decimal.MinValue).Plus(value1).Equals());
    }

// ----------------------------------------------------------------------------------------------

    // Division by Max Value
    private static IEnumerable DivisionTestData()
    {
        yield return new TestCaseData(0.2m);
        yield return new TestCaseData(0.3m);
        yield return new TestCaseData(0.30m);
    }

    [TestCaseSource(nameof(DivisionTestData))]
    public void GeneratorDataDrivenDivision(decimal value1)
    {
        // Assert
        Assert.Throws<OverflowException>(()=>this._calculator.Enter(decimal.MaxValue).DivideBy(value1).Equals());
    }

// --------------------------------------------------------------------------------------------
   
    //Divide by zero with Max value
    private static IEnumerable DivisionTestDataByZero()
    {
        yield return new TestCaseData(0m);
    }

    // use the [TestCaseSource] annotation here
    [TestCaseSource(nameof(DivisionTestDataByZero))]
    public void GeneratorDataDivisionByZeroWithMaxValue(decimal value1)
    {
        // Assert
        Assert.Throws<DivideByZeroException>(()=>this._calculator.Enter(decimal.MaxValue).DivideBy(value1));
    }

// --------------------------------------------------------------------------------------------

    //Divide by zero with min value
        private static IEnumerable DivisionTestDataByZeroMinValue()
        {
            yield return new TestCaseData(0m);
        }

        // use the [TestCaseSource] annotation here
        [TestCaseSource(nameof(DivisionTestDataByZeroMinValue))]
        public void GeneratorDataDivisionByMinValueZero(decimal value1)
        {
            // Assert
            Assert.Throws<DivideByZeroException>(()=>this._calculator.Enter(decimal.MinValue).DivideBy(value1).Equals());
    }

// ---------------------------------------------------------------------------------------------------
    //Divide with min value
        private static IEnumerable DivisionTestDataByMinValue()
        {
            yield return new TestCaseData(0.5m);
            yield return new TestCaseData(0.12m);
            yield return new TestCaseData(0.20m);

        }

        // use the [TestCaseSource] annotation here
        [TestCaseSource(nameof(DivisionTestDataByMinValue))]
        public void GeneratorDataDivisionByMinValue(decimal value1)
        {
            // Assert
            Assert.Throws<OverflowException>(()=>_calculator.Enter(decimal.MinValue).DivideBy(value1).Equals());
    }

// ---------------------------------------------------------------------------------------------------
   
    // Multiplication by Max value
    private static IEnumerable? MultiplicationTestMaxValueData()
    {
        yield return new TestCaseData(2m);
        yield return new TestCaseData(3m);
        yield return new TestCaseData(30m);
    }

    
    [TestCaseSource(nameof(MultiplicationTestMaxValueData))]
    public void GeneratorMultiplicationMax(decimal value1)
    {
        // Assert
        Assert.Throws<OverflowException>(()=>this._calculator.Enter(decimal.MaxValue).MultiplyBy(value1).Equals());
    }
    

// ---------------------------------------------------------------------------------------------------
   
    // Multiplication by Min value
    private static IEnumerable? MultiplicationTestMinValueData()
    {
        yield return new TestCaseData(2m);
        yield return new TestCaseData(3m);
        yield return new TestCaseData(30m);
    }

    
    [TestCaseSource(nameof(MultiplicationTestMinValueData))]
    public void GeneratorMultiplicationMin(decimal value1)
    {
        // Assert
        Assert.Throws<OverflowException>(()=>this._calculator.Enter(decimal.MinValue).MultiplyBy(value1));
    }

   [TearDown]
    public void Teardown()
    {
        TestContext.Progress.WriteLine("This is working");
    
    // This method will be executed after each test.
       _calculator.Reset();
    }
 
}
    