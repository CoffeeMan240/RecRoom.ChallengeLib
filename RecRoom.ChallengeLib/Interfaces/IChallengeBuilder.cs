namespace RecRoom.ChallengeLib.Interfaces;

public interface IChallengeBuilder
{
    public IChallenge Build()
    {
        return challenge;
    }

    public IChallenge challenge {get; set;}
}