namespace Calculators;

public class Calculator
{
    public DecimalCalculatorReset()
    {
        Reset();
    }

    private decimal LastResult { get; set; }

    public DecimalCalculator Reset()
    {
        LastResult = 0.0M;
        return this;
    }
    

    public DecimalCalculator Enter(decimal number)
    {
        LastResult = number;
        return this;
    }

    public DecimalCalculator Plus(decimal number)
    {
        LastResult += number;
        return this;
    }

    public DecimalCalculator Minus(decimal number)
    {
        LastResult -= number;
        return this;
    }

    public DecimalCalculator MultiplyBy(decimal number)
    {
        LastResult *= number;
        return this;
    }

    public DecimalCalculator DivideBy(decimal number)
    {
        LastResult /= number;
        return this;
    }

    public decimal Equals()
    {
        return LastResult;
    }
}