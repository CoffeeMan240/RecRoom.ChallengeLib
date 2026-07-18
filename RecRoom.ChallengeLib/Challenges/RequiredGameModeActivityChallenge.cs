using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;

public class RequiredGameModeActivityChallenge : RequiredObjectChallenge<LegacyGameModeType, int>
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.RequiredGameModeActivityChallenge;

    protected override int SerializeValue(LegacyGameModeType value)
    {
        return (int)value;
    }
    public RequiredGameModeActivityChallenge()
    {
    }

    public RequiredGameModeActivityChallenge(List<LegacyGameModeType> values)
    {
        Values = values;
    }

    public RequiredGameModeActivityChallenge(List<LegacyGameModeType> values, bool inclusive)
    {
        Values = values;
        Inclusive = inclusive;
    }

    public RequiredGameModeActivityChallenge(List<LegacyGameModeType> values, bool inclusive, bool excludesIncludesNull)
    {
        Values = values;
        Inclusive = inclusive;
        ExcludesIncludesNull = excludesIncludesNull;
    }

    public RequiredGameModeActivityChallenge(LegacyGameModeType value) : this(new List<LegacyGameModeType>() { value }){}
    public RequiredGameModeActivityChallenge(LegacyGameModeType value, bool inclusive) : this(new List<LegacyGameModeType>(){value},  inclusive){}
    public RequiredGameModeActivityChallenge(LegacyGameModeType value, bool inclusive, bool excludesIncludesNull) : this(new List<LegacyGameModeType>(){value},  inclusive, excludesIncludesNull){}
}