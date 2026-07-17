using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;

public class RequiredGameModeActivityChallenge : RequiredObjectChallenge<LegacyGameModeType, int>
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.RequiredGameModeActivityChallenge;

    protected override int SerializeValue(LegacyGameModeType value)
    {
        return (int)value;
    }
    public RequiredGameModeActivityChallenge(){}

    public RequiredGameModeActivityChallenge(List<LegacyGameModeType> types)
    {
        Values = types;
    }
}