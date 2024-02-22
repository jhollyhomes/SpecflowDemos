namespace SimpleCalculator.UnitTests;

[TestFixture]
public class CalculatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(1, 0, 1)]
    [TestCase(114, 22, 136)]
    [TestCase(24, 5, 29)]
    [TestCase(0, 5, 5)]
    public void GivenTwoNumbers_WhenAdding_ReturnsCorrectResult(int firstNumber, int secondNumber, int total)
    {
        var calculator = new Calculator
        {
            FirstNumber = firstNumber,
            SecondNumber = secondNumber
        };

        var result = calculator.Add();

        Assert.That(result, Is.EqualTo(total));
    }
}