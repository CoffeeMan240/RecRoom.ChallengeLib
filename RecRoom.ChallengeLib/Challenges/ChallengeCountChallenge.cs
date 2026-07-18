using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib.Challenges;

public class ChallengeCountChallenge : Challenge
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.BoolVarEqualsChallenge;
    
    public List<IChallenge> ChallengesToCount { get; set; }
    public int RequiredCount { get; set; }

    public override Dictionary<string, object> Serialize()
    {
        var dictionary = base.Serialize();
        var ctc = new List<Dictionary<string, object>>();
        foreach (var challenge in ChallengesToCount)
        {
            ctc.Add(challenge.Serialize());
        }
        dictionary.Add("ctc", ctc);
        dictionary.Add("t", RequiredCount);
        return dictionary;
    }
    
    public ChallengeCountChallenge(){}
    public ChallengeCountChallenge(int requiredCount, List<IChallenge> challengesToCount){RequiredCount = requiredCount;ChallengesToCount = challengesToCount;}
    public ChallengeCountChallenge(int requiredCount, IChallenge challengeToCount){RequiredCount = requiredCount;ChallengesToCount = new List<IChallenge>(){challengeToCount};}
}