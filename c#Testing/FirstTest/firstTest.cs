using Calculators;

namespace FirstTests;

public class FirstTests
{
    [Test]
    public void AdditionTestOne()
    {
        // Arrange
        var calculator = new DecimalCalculator();

        // Act
        var result = calculator.Enter(4).Plus(2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void SubtractionTestOne()
    {
        // Arrange
        var calculator = new DecimalCalculator();

        // Act
        var result = calculator.Enter(4).Minus(2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void MultiplicationTestOne()
    {
        // Arrange
        var calculator = new DecimalCalculator();

        // Act
        var result = calculator.Enter(4).MultiplyBy(2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(8));
    }

     [Test]
    public void DivisionTestOne()
    {
        // Arrange
        var calculator = new DecimalCalculator();

        // Act
        var result = calculator.Enter(4).DivideBy(2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }

    
}