namespace RecRoom.ChallengeLib.Typed;

public class IntConstantNumResolver : ConstantNumResolver<int>
{
    public IntConstantNumResolver(){}
    public IntConstantNumResolver(int constant)
    : base(constant){}
}