using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib;

public class Challenge : ChallengeBase
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.Challenge;

    public override Dictionary<string, object> Serialize()
    {
        var baseChallenge = base.Serialize();
        var withConditions = new List<Dictionary<string, object>>();
        foreach (var item in WithConditions)
        {
            withConditions.Add(item.Serialize());
        }
        if (ResetConditions.Count > 0)
        {
            var resetConditions = new List<Dictionary<string, object>>();
            foreach (var item in ResetConditions)
            {
                resetConditions.Add(item.Serialize());
            }
            baseChallenge.Add("rc", resetConditions);
        }
        baseChallenge.Add("wc", withConditions);
        if (IgnorePreviousCompletions)
        {
            baseChallenge.Add("ipc", true);
        }
        return baseChallenge;
    }

    public bool IgnorePreviousCompletions { get; set; } = false;
    public List<IChallenge> WithConditions { get; set; } = new List<IChallenge>();
    public List<IChallenge> ResetConditions { get; set; } = new List<IChallenge>();
}