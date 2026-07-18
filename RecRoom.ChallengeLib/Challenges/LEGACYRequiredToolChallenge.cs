using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;
[Obsolete("This was removed for some reason")]
public class LEGACYRequiredToolChallenge : RequiredObjectChallenge<SpawnableToolTypes, int>
{
    public override ChallengeTypes ChallengeType { get; }

    protected override int SerializeValue(SpawnableToolTypes value)
    {
        return (int)value;
    }
    public LEGACYRequiredToolChallenge(){}

    public LEGACYRequiredToolChallenge(List<SpawnableToolTypes> types)
    {
        Values = types;
    }
}