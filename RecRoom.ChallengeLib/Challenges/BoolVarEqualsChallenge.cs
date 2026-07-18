namespace RecRoom.ChallengeLib.Challenges;

public class BoolVarEqualsChallenge : VarEqualsChallenge<bool, bool>
{
    protected override bool SerializeValue(bool value)
    {
        return value;
    }
    
    public BoolVarEqualsChallenge(string varKey, bool value)
        : base(varKey, true, new List<bool>(){value})
    {
        
    }
}