using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib;

public abstract class RequiredObjectChallenge <T,TSerialized> : ChallengeBase
{
    public override ChallengeTypes ChallengeType { get; }
    
    public bool Inclusive { get; set; }
    public bool ExcludesIncludesNull { get; set; }

    public List<T> Values;
    public override Dictionary<string, object> Serialize()
    {
        var dictionary = base.Serialize();
        if(Inclusive){dictionary.Add("in", Inclusive);}
        if(ExcludesIncludesNull){dictionary.Add("ex", ExcludesIncludesNull);}

        List<TSerialized> values = new List<TSerialized>();
        foreach (var value in Values)
        {
            values.Add(SerializeValue(value));
        }
        dictionary.Add("vs", values);
        return dictionary;
    }

    protected abstract TSerialized SerializeValue(T value);
}