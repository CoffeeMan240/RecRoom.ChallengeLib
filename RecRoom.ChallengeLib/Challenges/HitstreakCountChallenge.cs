using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;

//macroing macros man
public class HitstreakCountChallenge : TimedBufferChallenge
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.HitstreakCountChallenge;
}