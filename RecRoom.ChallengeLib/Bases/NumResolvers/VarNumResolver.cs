using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib;

public class VarNumResolver<T> : NumberResolver<T>
{
    public string VarKey { get; set; }
    public NumResolverType Type { get; } = NumResolverType.Var;
    public override Dictionary<string, object> Serialize()
    {
        var dictionary =  base.Serialize();
        dictionary.Add("vk", VarKey);
        return dictionary;
    }
    public VarNumResolver(){}
    public VarNumResolver(string varKey)
    {
        VarKey = varKey;
    }
}