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

    [Test]
    public void LikeDislikeNeutral_ShouldReturnCorrectOUTCOME_WhenListCountIsThree()
    {
        List<Outcome> testInputSequence = new List<Outcome>();
        testInputSequence.Add(Outcome.LIKE);
        testInputSequence.Add(Outcome.LIKE);
        testInputSequence.Add(Outcome.DISLIKE);

        Outcome output = LikeDislike.LikeDislikeNeutral(testInputSequence);

        output.ShouldBe(Outcome.DISLIKE);
    }

    [Test]
    public void LikeDislikeNeutral_ShouldReturnCorrectOUTCOME()
    {
        List<Outcome> testInputSequence = new List<Outcome>();
        testInputSequence.Add(Outcome.LIKE);
        testInputSequence.Add(Outcome.LIKE);
        testInputSequence.Add(Outcome.DISLIKE);

        List<Outcome> testInputSequence2 = new List<Outcome>();
        testInputSequence2.Add(Outcome.DISLIKE);
        testInputSequence2.Add(Outcome.LIKE);
        testInputSequence2.Add(Outcome.DISLIKE);
        testInputSequence2.Add(Outcome.DISLIKE);

        List<Outcome> testInputSequence3 = new List<Outcome>();
        testInputSequence3.Add(Outcome.DISLIKE);
        testInputSequence3.Add(Outcome.DISLIKE);
        testInputSequence3.Add(Outcome.LIKE);
        testInputSequence3.Add(Outcome.LIKE);
        testInputSequence3.Add(Outcome.LIKE);

        Outcome output = LikeDislike.LikeDislikeNeutral(testInputSequence);
        Outcome output2 = LikeDislike.LikeDislikeNeutral(testInputSequence2);
        Outcome output3 = LikeDislike.LikeDislikeNeutral(testInputSequence3);

        Assert.Multiple(() =>
        {
            output.ShouldBe(Outcome.DISLIKE);
            output2.ShouldBe(Outcome.NEUTRAL);
            output3.ShouldBe(Outcome.LIKE);
        });
        
    }

}
