using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalChallengeFizzBuzz;

namespace TechnicalChallengeFizzBuzzUnitTests;

[TestClass]
public class FizzBuzzServiceUnitTests
{
    private FizzBuzzService fizzBuzzService;

    [TestInitialize]
    public void StartUp()
    {
        fizzBuzzService = new FizzBuzzService();
    }

    [TestMethod]
    public void SuccessfulIsMultipleOfThree()
    {
        // Arrange 
        int numberToCheck = 45;

        // Act
        bool result = fizzBuzzService.IsMultipleOfThree(numberToCheck);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void UnsuccessfulIsMultipleOfThree()
    {
        // Arrange 
        int numberToCheck = 67;

        // Act
        bool result = fizzBuzzService.IsMultipleOfThree(numberToCheck);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void SuccessfulIsMultipleOfFive()
    {
        // Arrange 
        int numberToCheck = 6385;

        // Act
        bool result = fizzBuzzService.IsMultipleOfThree(numberToCheck);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void UnsuccessfulIsMultipleOfFive()
    {
        // Arrange 
        int numberToCheck = -22;

        // Act
        bool result = fizzBuzzService.IsMultipleOfFive(numberToCheck);

        // Assert
        Assert.IsFalse(result);
    }
}