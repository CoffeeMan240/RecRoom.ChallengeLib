using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib.Challenges;

public class RequiredToolChallenge : Challenge
{
    public RequiredToolChallenge() { }

    public RequiredToolChallenge(SpawnableToolTypes tool)
    {
        WithConditions.Add(new RequiredEventTypeChallenge(ChallengeEventTypes.PickedUpTool));
        WithConditions.Add(new DynamicIntArithmaticChallenge(MathOperations.EQ, new VarNumResolver<int>("t_t"), new ConstantNumResolver<int>((int)tool)));
    }
}