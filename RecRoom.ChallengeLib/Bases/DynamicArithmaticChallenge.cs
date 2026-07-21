using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib;
public abstract class DynamicArithmaticChallenge<T> : ChallengeBase
{
    public MathOperations MathOperation { get; set; }
    public INumResolver<T> NumResolverA { get; set; }
    public INumResolver<T> NumResolverB { get; set; }

    public override Dictionary<string, object> Serialize()
    {
        var dictionary = base.Serialize();
        dictionary.Add("op", (int)MathOperation);
        if (NumResolverA != null)
        {
            dictionary.Add("rA", NumResolverA.Serialize());
        }
        if (NumResolverA != null)
        {
            dictionary.Add("rB", NumResolverB.Serialize());
        }
        return dictionary;
    }
    
    public DynamicArithmaticChallenge(){}

    public DynamicArithmaticChallenge(MathOperations mathOperation, INumResolver<T> numResolverA,
        INumResolver<T> numResolverB)
    {
        MathOperation = mathOperation;
        NumResolverA = numResolverA;
        NumResolverB = numResolverB;
    }
}