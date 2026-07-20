using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;
[Obsolete("This was removed for some reason in later versions. For Legacy vers of RR before mid-late 2020, ignore me! :3", false)]
public class LEGACYRequiredToolChallenge : RequiredObjectChallenge<SpawnableToolTypes, int>
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.RequiredToolChallenge;

    protected override int SerializeValue(SpawnableToolTypes value)
    {
        return (int)value;
    }
    public LEGACYRequiredToolChallenge()
    {
    }

    public LEGACYRequiredToolChallenge(List<SpawnableToolTypes> values)
    {
        Values = values;
    }

    public LEGACYRequiredToolChallenge(List<SpawnableToolTypes> values, bool inclusive)
    {
        Values = values;
        Inclusive = inclusive;
    }

    public LEGACYRequiredToolChallenge(List<SpawnableToolTypes> values, bool inclusive, bool excludesIncludesNull)
    {
        Values = values;
        Inclusive = inclusive;
        ExcludesIncludesNull = excludesIncludesNull;
    }

    public LEGACYRequiredToolChallenge(SpawnableToolTypes value) : this(new List<SpawnableToolTypes>() { value }){}
    public LEGACYRequiredToolChallenge(SpawnableToolTypes value, bool inclusive) : this(new List<SpawnableToolTypes>(){value},  inclusive){}
    public LEGACYRequiredToolChallenge(SpawnableToolTypes value, bool inclusive, bool excludesIncludesNull) : this(new List<SpawnableToolTypes>(){value},  inclusive, excludesIncludesNull){}
}