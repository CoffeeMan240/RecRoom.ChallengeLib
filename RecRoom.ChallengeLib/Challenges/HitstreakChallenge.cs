using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib.Challenges;
//a macro
public class HitstreakChallenge : ChallengeCountChallenge
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.HitstreakChallenge;
    
    public HitstreakChallenge(){}

    public HitstreakChallenge(int hitsPerStreak)
        :base(hitsPerStreak, new List<IChallenge>(){ChallengeBuilder.CreateBuilder().WithCondition(new RequiredEventTypeChallenge(new List<ChallengeEventTypes>()
            {
                ChallengeEventTypes.ElminatedOtherPlayer
            })).Build()})
    {
        this.ResetConditions.Add(new RequiredEventTypeChallenge(new List<ChallengeEventTypes>()
            {
                ChallengeEventTypes.LocalPlayerEliminated
            }));
    }
}