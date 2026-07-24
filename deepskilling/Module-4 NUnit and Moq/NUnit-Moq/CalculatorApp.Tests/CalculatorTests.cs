using NUnit.Framework;
using CalculatorApp;

namespace CalculatorApp.Tests;

public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_ReturnsCorrectResult()
    {
        Assert.AreEqual(10, calculator.Add(4, 6));
    }

    [Test]
    public void Subtract_ReturnsCorrectResult()
    {
        Assert.AreEqual(5, calculator.Subtract(10, 5));
    }

    [Test]
    public void Multiply_ReturnsCorrectResult()
    {
        Assert.AreEqual(20, calculator.Multiply(4, 5));
    }

    [Test]
    public void Divide_ReturnsCorrectResult()
    {
        Assert.AreEqual(5, calculator.Divide(25, 5));
    }
}