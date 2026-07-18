using RecRoom.ChallengeLib.Challenges;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib;

public class ChallengeCountChallengeBuilder : IChallengeBuilder
{
    public static ChallengeCountChallengeBuilder CreateBuilder(int count)
    {
        return new ChallengeCountChallengeBuilder(count);
    }

    public ChallengeCountChallengeBuilder(int count)
    {
        challenge = new ChallengeCountChallenge(count, new List<IChallenge>());
    }

    public ChallengeCountChallengeBuilder WithCondition(IChallenge challenge)
    {
        ((ChallengeCountChallenge)challenge).ChallengesToCount.Add(challenge);
        return this;
    }

    public ChallengeCountChallengeBuilder ResetCondition(IChallenge challenge)
    {
        ((ChallengeCountChallenge)challenge).ResetConditions.Add(challenge);
        return this;
    }
    public IChallenge challenge { get; set; }
}