using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;

public class RequiredEnemyTypeChallenge : RequiredObjectChallenge<EnemyTypes, int>
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.RequiredEnemyTypeChallenge;

    protected override int SerializeValue(EnemyTypes value)
    {
       return (int)value;
    }

    public RequiredEnemyTypeChallenge()
    {
    }

    public RequiredEnemyTypeChallenge(List<EnemyTypes> values)
    {
        Values = values;
    }

    public RequiredEnemyTypeChallenge(List<EnemyTypes> values, bool inclusive)
    {
        Values = values;
        Inclusive = inclusive;
    }

    public RequiredEnemyTypeChallenge(List<EnemyTypes> values, bool inclusive, bool excludesIncludesNull)
    {
        Values = values;
        Inclusive = inclusive;
        ExcludesIncludesNull = excludesIncludesNull;
    }

    public RequiredEnemyTypeChallenge(EnemyTypes value) : this(new List<EnemyTypes>() { value }){}
    public RequiredEnemyTypeChallenge(EnemyTypes value, bool inclusive) : this(new List<EnemyTypes>(){value},  inclusive){}
    public RequiredEnemyTypeChallenge(EnemyTypes value, bool inclusive, bool excludesIncludesNull) : this(new List<EnemyTypes>(){value},  inclusive, excludesIncludesNull){}
}