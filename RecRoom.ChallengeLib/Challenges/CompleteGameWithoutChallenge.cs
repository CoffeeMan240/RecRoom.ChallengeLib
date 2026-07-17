using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib.Challenges;

public class CompleteGameWithoutChallenge : TimedBufferChallenge
{
    //seems to be a macro basicly
    public override ChallengeTypes ChallengeType { get; } =  ChallengeTypes.CompleteGameWithoutChallenge;

    public CompleteGameWithoutChallenge(){}

    public CompleteGameWithoutChallenge(IChallenge gameStartChallenge, IChallenge endGameChallenge,
        List<IChallenge> resetChallenges)
        : base(new List<IChallenge>() { gameStartChallenge, endGameChallenge }, 2, -1)
    {
        this.ResetConditions.Add(new RequiredEventTypeChallenge(new List<ChallengeEventTypes>()
            {
                ChallengeEventTypes.GameStart
            }));
        foreach (var challenge in resetChallenges)
        {
            ResetConditions.Add(challenge);
        }
    }
}