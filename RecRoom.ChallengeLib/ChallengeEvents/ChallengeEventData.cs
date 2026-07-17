using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib.ChallengeEvents;

public class ChallengeEventData : IChallengeEventData
{
    public RoomSceneLocations Location { get; set; }
    
    public Dictionary<string, object> ExtraVariables { get; set; }

    public Dictionary<string, object> Serialize()
    {
        var dictionary = new Dictionary<string, object>();
        dictionary.Add("l", Location);
        dictionary.Add("cet", ExtraVariables);
        return dictionary;
    }

    public void SetVar(string var, object value)
    {
        ExtraVariables.Add(var, value);
    }
    //now heres the hell part
    
}