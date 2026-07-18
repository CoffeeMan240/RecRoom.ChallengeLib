using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib.Challenges;

//macroing macros man
public class HitstreakCountChallenge : TimedBufferChallenge
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.HitstreakCountChallenge;

    public HitstreakCountChallenge(int hitPerStreak, int totalCount, bool notify)
        :base(new List<IChallenge>(){new HitstreakChallenge(hitPerStreak)}, totalCount, -1)
    {
        this.PersistBuffer = true;
        this.ProgressMode = TimedBufferChallengeProgressMode.Count;
        if (notify)
        {
            this.NotificationCounts.AddRange([1,2,3,4]);
        }
    }
}