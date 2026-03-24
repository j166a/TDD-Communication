using Shouldly;

namespace TDD_Communication.Tests;

public class LikeDislikeTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(Outcome.LIKE, Outcome.LIKE)]
    [TestCase(Outcome.DISLIKE, Outcome.DISLIKE)]
    public void LikeDislikeNeutral_ShouldReturnInput_WhenPassedOneInput(Outcome input, Outcome expected)
    {
        Outcome output = LikeDislike.LikeDislikeNeutral(input);
        output.ShouldBe(expected);
    }
}
