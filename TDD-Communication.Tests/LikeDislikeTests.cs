using Shouldly;

namespace TDD_Communication.Tests;

public class LikeDislikeTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void LikeDislikeNeutral_ShouldReturnLIKE_WhenPassedOneLIKE()
    {
        List<Outcome> testInputSequence = new List<Outcome>();
        testInputSequence.Add(Outcome.LIKE);

        Outcome output = LikeDislike.LikeDislikeNeutral(testInputSequence);
        output.ShouldBe(Outcome.LIKE);
    }

    [Test]
    public void LikeDislikeNeutral_ShouldReturnNEUTRAL_WhenPassedOneLIKEOneDISLIKE()
    {
        List<Outcome> testInputSequence = new List<Outcome>();
        testInputSequence.Add(Outcome.LIKE);
        testInputSequence.Add(Outcome.DISLIKE);


        Outcome output = LikeDislike.LikeDislikeNeutral(testInputSequence);
        output.ShouldBe(Outcome.NEUTRAL);
    }

    [Test]
    public void LikeDislikeNeutral_ShouldReturnLIKE_WhenPassedTwoLIKE()
    {
        List<Outcome> testInputSequence = new List<Outcome>();
        testInputSequence.Add(Outcome.LIKE);
        testInputSequence.Add(Outcome.LIKE);


        Outcome output = LikeDislike.LikeDislikeNeutral(testInputSequence);
        output.ShouldBe(Outcome.NEUTRAL);
    }


}
