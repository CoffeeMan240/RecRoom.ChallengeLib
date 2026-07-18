using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib.Challenges;

public class DynamicIntArithmaticChallenge : DynamicArithmaticChallenge<int>
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.DynamicIntArithmeticChallenge;
    
    public DynamicIntArithmaticChallenge() { }
    public DynamicIntArithmaticChallenge(MathOperations numOp, INumResolver<int> numResolverA, INumResolver<int> numResolverB)
        :base(numOp, numResolverA, numResolverB) { }
}