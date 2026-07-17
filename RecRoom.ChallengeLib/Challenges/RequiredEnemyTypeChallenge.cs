using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;

public class RequiredEnemyTypeChallenge : RequiredObjectChallenge<EnemyTypes, int>
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.RequiredEnemyTypeChallenge;

    protected override int SerializeValue(EnemyTypes value)
    {
       return (int)value;
    }

    public RequiredEnemyTypeChallenge(){}

    public RequiredEnemyTypeChallenge(List<EnemyTypes> types)
    {
        Values = types;
    }
}