using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib;

public class ChallengeBuilder : IChallengeBuilder
{
    public static ChallengeBuilder CreateBuilder()
    {
        return new ChallengeBuilder();
    }
    public ChallengeBuilder()
    {
        challenge = new Challenge();
    }

    public ChallengeBuilder WithCondition(IChallenge withChallenge)
    {
        ((Challenge)challenge).WithConditions.Add(withChallenge);
        return this;
    }
    public ChallengeBuilder ResetCondition(IChallenge resetChallenge)
    {
        ((Challenge)challenge).ResetConditions.Add(resetChallenge);
        return this;
    }

    public IChallenge Build()
    {
        return this.challenge;
    }

    public IChallenge challenge { get; set; }
}