using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib;

public class NumberResolver<T> : INumResolver<T>
{
    public virtual Dictionary<string, object> Serialize()
    {
        var dictionary = new Dictionary<string, object>();
        dictionary.Add("t", (int)Type);
        return dictionary;
    }

    public NumResolverType Type { get; }
}