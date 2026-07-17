using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib;

public abstract class ChallengeBase : IChallenge
{
    public abstract ChallengeTypes ChallengeType { get; }

    public virtual Dictionary<string, object> Serialize()
    {
        var dictionary = new Dictionary<string, object>();
        dictionary.Add("ct", ChallengeType);
        return dictionary;
    }
}