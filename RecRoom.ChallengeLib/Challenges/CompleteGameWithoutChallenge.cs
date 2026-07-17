using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;

public class CompleteGameWithoutChallenge : TimedBufferChallenge
{
    //seems to be a macro basicly
    public override ChallengeTypes ChallengeType { get; } =  ChallengeTypes.CompleteGameWithoutChallenge;
}