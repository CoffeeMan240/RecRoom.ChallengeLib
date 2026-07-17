using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;
[Obsolete("This was removed for some reason")]
public class RequiredToolChallenge : RequiredObjectChallenge<SpawnableToolTypes, int>
{
    public override ChallengeTypes ChallengeType { get; }

    protected override int SerializeValue(SpawnableToolTypes value)
    {
        return (int)value;
    }
    public RequiredToolChallenge(){}

    public RequiredToolChallenge(List<SpawnableToolTypes> types)
    {
        Values = types;
    }
}