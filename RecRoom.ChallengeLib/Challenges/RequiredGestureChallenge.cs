using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;
public class RequiredGestureChallenge : VarEqualsChallenge<PlayerGesture, int>
{
    public RequiredGestureChallenge(string varKey) : base(varKey)
    {
    }

    public RequiredGestureChallenge(string varKey, bool inclusive = false, List<PlayerGesture> requiredValues = null) : base(varKey, inclusive, requiredValues)
    {
    }
    protected override int SerializeValue(PlayerGesture value)
    {
        return (int)value;
    }
}