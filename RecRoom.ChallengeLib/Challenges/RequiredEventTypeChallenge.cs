using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;

public class RequiredEventTypeChallenge : RequiredObjectChallenge<ChallengeEventTypes, int>
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.RequiredEventTypeChallenge;

    protected override int SerializeValue(ChallengeEventTypes value)
    {
        return (int)value;
    }
    public RequiredEventTypeChallenge(){}

    public RequiredEventTypeChallenge(List<ChallengeEventTypes> types)
    {
        Values = types;
    }
    public RequiredEventTypeChallenge(ChallengeEventTypes value) : this([value]){}
}