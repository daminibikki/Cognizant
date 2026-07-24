using CalculatorApp;
using Moq;
using NUnit.Framework;

namespace CalculatorApp.Tests;

public class GreetingTests
{
    [Test]
    public void Welcome_ReturnsMockMessage()
    {
        // Arrange
        var mockService = new Mock<IMessageService>();

        mockService.Setup(x => x.GetMessage())
                   .Returns("Welcome to NUnit and Moq");

        var greeting = new Greeting(mockService.Object);

        // Act
        var result = greeting.Welcome();

        // Assert
        Assert.AreEqual("Welcome to NUnit and Moq", result);
    }
}