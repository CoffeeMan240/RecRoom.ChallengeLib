using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;

public class RequiredEventTypeChallenge : RequiredObjectChallenge<ChallengeEventTypes, int>
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.RequiredEventTypeChallenge;

    protected override int SerializeValue(ChallengeEventTypes value)
    {
        return (int)value;
    }
    public RequiredEventTypeChallenge()
    {
    }

    public RequiredEventTypeChallenge(List<ChallengeEventTypes> values)
    {
        Values = values;
    }

    public RequiredEventTypeChallenge(List<ChallengeEventTypes> values, bool inclusive)
    {
        Values = values;
        Inclusive = inclusive;
    }

    public RequiredEventTypeChallenge(List<ChallengeEventTypes> values, bool inclusive, bool excludesIncludesNull)
    {
        Values = values;
        Inclusive = inclusive;
        ExcludesIncludesNull = excludesIncludesNull;
    }

    public RequiredEventTypeChallenge(ChallengeEventTypes value) : this(new List<ChallengeEventTypes>() { value }){}
    public RequiredEventTypeChallenge(ChallengeEventTypes value, bool inclusive) : this(new List<ChallengeEventTypes>(){value},  inclusive){}
    public RequiredEventTypeChallenge(ChallengeEventTypes value, bool inclusive, bool excludesIncludesNull) : this(new List<ChallengeEventTypes>(){value},  inclusive, excludesIncludesNull){}

}