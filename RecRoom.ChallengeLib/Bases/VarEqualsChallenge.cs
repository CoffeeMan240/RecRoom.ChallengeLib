namespace RecRoom.ChallengeLib;

public class VarEqualsChallenge <T,TSerialized> : RequiredObjectChallenge<T,TSerialized>
{
    public override Dictionary<string, object> Serialize()
    {
        var dictionary = base.Serialize();
        dictionary.Add("v", VarKey);
        return dictionary;
    }

    protected override TSerialized SerializeValue(T value)
    {
        throw new NotImplementedException();
    }

    public string VarKey;

    public VarEqualsChallenge(string varKey)
    {
        this.VarKey = varKey;
    }

    public VarEqualsChallenge(string varKey, bool inclusive = false, List<T> requiredValues = null)
    {
        this.VarKey = varKey;
        Inclusive = inclusive;
        Values = requiredValues;
    }
}