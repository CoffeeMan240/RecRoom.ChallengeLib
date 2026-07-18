namespace RecRoom.ChallengeLib.Typed;

public class FloatConstantNumResolver : ConstantNumResolver<float>
{
    public FloatConstantNumResolver(){}
    public FloatConstantNumResolver(float constant)
    : base(constant){}
}