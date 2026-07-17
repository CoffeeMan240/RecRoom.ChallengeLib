using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Interfaces;

public interface IChallenge
{
    public ChallengeTypes ChallengeType { get; }
    public Dictionary<string, object> Serialize();
}