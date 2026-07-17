using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;

public class RequiredToolChallenge : RequiredObjectChallenge<SpawnableToolTypes, int>
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.RequiredToolChallenge;
    public override int SerializeValue(SpawnableToolTypes value)
    {
        return (int)value;
    }
    public RequiredToolChallenge(){}

    public RequiredToolChallenge(List<SpawnableToolTypes> types)
    {
        Values = types;
    }
}