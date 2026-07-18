using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;
public class RequiredGestureChallenge : VarEqualsChallenge<PlayerGesture, int>
{
    public RequiredGestureChallenge() : base("hg")
    {
    }

    public RequiredGestureChallenge(PlayerGesture requiredValue) : base("hg", true, new List<PlayerGesture>(){requiredValue})
    {
    }
    public RequiredGestureChallenge(bool inclusive, PlayerGesture requiredValue) : base("hg", inclusive, new List<PlayerGesture>(){requiredValue})
    {
    }
    
    protected override int SerializeValue(PlayerGesture value)
    {
        return (int)value;
    }
}