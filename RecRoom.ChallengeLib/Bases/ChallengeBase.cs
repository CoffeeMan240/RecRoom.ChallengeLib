using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib;

public abstract class ChallengeBase : IChallenge
{
    public abstract ChallengeTypes ChallengeType { get; }
    public bool IgnorePreviousCompletions { get; set; }

    public virtual Dictionary<string, object> Serialize()
    {
        var dictionary = new Dictionary<string, object>();
        dictionary.Add("ct", ChallengeType);
        dictionary.Add("ipc", IgnorePreviousCompletions);
        return dictionary;
    }
}