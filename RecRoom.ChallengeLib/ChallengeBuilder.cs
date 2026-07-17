using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib;

public class ChallengeBuilder
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
        challenge.WithConditions.Add(withChallenge);
        return this;
    }
    public ChallengeBuilder ResetCondition(IChallenge resetChallenge)
    {
        challenge.ResetConditions.Add(resetChallenge);
        return this;
    }

    public Challenge Build()
    {
        return this.challenge;
    }
    private Challenge challenge;
}