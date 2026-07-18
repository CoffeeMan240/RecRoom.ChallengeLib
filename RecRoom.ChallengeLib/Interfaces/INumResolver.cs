using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Interfaces;

public interface INumResolver<T>
{
    public abstract NumResolverType Type { get; }
    public Dictionary<string, object> Serialize();
}