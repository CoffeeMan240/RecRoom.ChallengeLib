using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;
//a macro
public class HitstreakChallenge : ChallengeCountChallenge
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.HitstreakChallenge;
}