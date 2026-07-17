using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Interfaces;

public interface IChallengeEventData
{
    public RoomSceneLocations Location { get; set; }
    public Dictionary<string, object> ExtraVariables { get; set; }
}