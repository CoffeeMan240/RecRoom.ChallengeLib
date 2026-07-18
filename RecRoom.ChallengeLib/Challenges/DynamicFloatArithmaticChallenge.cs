using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib.Challenges;

public class DynamicFloatArithmaticChallenge : DynamicArithmaticChallenge<float>
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.DynamicFloatArithmeticChallenge;
    
    public DynamicFloatArithmaticChallenge() { }
    public DynamicFloatArithmaticChallenge(MathOperations numOp, INumResolver<float> numResolverA, INumResolver<float> numResolverB)
        :base(numOp, numResolverA, numResolverB) { }
}