using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib;

public class ConstantNumResolver<T> : NumberResolver<T>
{
    public T Constant = default(T);
    public override NumResolverType Type { get; } = NumResolverType.Constant;
    public override Dictionary<string, object> Serialize()
    {
        var dictionary = base.Serialize();
        dictionary.Add("c", Constant);
        return dictionary;
    }
    
    public ConstantNumResolver(){}
    public ConstantNumResolver(T constant)
    {
        Constant = constant;
    }
}