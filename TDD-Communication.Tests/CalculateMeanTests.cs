using Shouldly;

namespace TDD_Communication.Tests;

public class CalculateMeanTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculateTheMean_ShouldReturnZero_WhenArrayIsEmpty()
    {
        double[] input = [];

        double output = CalculateMean.CalculateTheMean(input);

        output.ShouldBe(0);
    }
    [Test]
    public void CalculateTheMean_ShouldReturnTheMean()
    {
        double[] input = [40, 16, 5, 8];

        double output = CalculateMean.CalculateTheMean(input);

        output.ShouldBe(17.25);
    }

}
