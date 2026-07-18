using RecRoom.ChallengeLib.Enums;

namespace RecRoom.ChallengeLib.Challenges;

public class RequiredRoomSceneLocationChallenge : RequiredObjectChallenge<RoomSceneLocations, Dictionary<string, object>>
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.RequiredRoomSceneLocationChallenge;

    protected override Dictionary<string, object> SerializeValue(RoomSceneLocations value)
    {
        var dictionary = new Dictionary<string, object>();
        dictionary.Add("l", RoomSceneIdMappings[value]);
        return dictionary;
    }

    private Dictionary<RoomSceneLocations, string> RoomSceneIdMappings = new Dictionary<RoomSceneLocations, string>()
    {
        { RoomSceneLocations.INVALID, Guid.Empty.ToString() },
        { RoomSceneLocations.DORM_ROOM, "76d98498-60a1-430c-ab76-b54a29b7a163" },
        { RoomSceneLocations.REC_CENTER, "cbad71af-0831-44d8-b8ef-69edafa841f6" },
        { RoomSceneLocations.LEGACY_CHARADES, "4078dfed-24bb-4db7-863f-578ba48d726b" },
        { RoomSceneLocations.LAKE, "f6f7256c-e438-4299-b99e-d20bef8cf7e0" },
        { RoomSceneLocations.PROPULSION, "d9378c9f-80bc-46fb-ad1e-1bed8a674f55" },
        { RoomSceneLocations.DODGEBALL, "3d474b26-26f7-45e9-9a36-9b02847d5e6f" },
        { RoomSceneLocations.THE_LOUNGE, "a067557f-ca32-43e6-b6e5-daaec60b4f5a" },
        { RoomSceneLocations.PADDLEBALL, "d89f74fa-d51e-477a-a425-025a891dd499" },
        { RoomSceneLocations.RIVER, "e122fe98-e7db-49e8-a1b1-105424b6e1f0" },
        { RoomSceneLocations.HOMESTEAD, "a785267d-c579-42ea-be43-fec1992d1ca7" },
        { RoomSceneLocations.QUARRY, "ff4c6427-7079-4f59-b22a-69b089420827" },
        { RoomSceneLocations.CLEAR_CUT, "380d18b5-de9c-49f3-80f7-f4a95c1de161" },
        { RoomSceneLocations.SPILLWAY, "58763055-2dfb-4814-80b8-16fac5c85709" },
        { RoomSceneLocations.QUEST_FOR_THE_GOLDEN_TROPHY, "91e16e35-f48f-4700-ab8a-a1b79e50e51b" },
        { RoomSceneLocations.ORIENTATION, "c79709d8-a31b-48aa-9eb8-cc31ba9505e8" },
        { RoomSceneLocations.THE_RISE_OF_JUMBOTRON, "acc06e66-c2d0-4361-b0cd-46246a4c455c" },
        { RoomSceneLocations.CURSE_OF_THE_CRIMSON_CAULDRON, "949fa41f-4347-45c0-b7ac-489129174045" },
        { RoomSceneLocations.THE_ISLE_OF_LOST_SKULLS, "7e01cfe0-820a-406f-b1b3-0a5bf575235c" },
        { RoomSceneLocations.SOCCER, "6d5eea4b-f069-4ed0-9916-0e2f07df0d03" },
        { RoomSceneLocations.PERFORMANCE_HALL, "9932f88f-3929-43a0-a012-a40b5128e346" },
        { RoomSceneLocations.PSVR_ROOM_CALIBRATION, "f5fbd9c9-e853-4036-9d48-5f68e861af04" },
        { RoomSceneLocations.PARK, "0a864c86-5a71-4e18-8041-8124e4dc9d98" },
        { RoomSceneLocations.WAREHOUSE, "239e676c-f12f-489f-bf3a-d4c383d692c3" },
        { RoomSceneLocations.CYBERJUNK_CITY, "9d6456ce-6264-48b4-808d-2d96b3d91038" },
        { RoomSceneLocations.MAKER_ROOM, "a75f7547-79eb-47c6-8986-6767abcb4f92" },
        { RoomSceneLocations.FRONTIER_SOLOS, "b010171f-4875-4e89-baba-61e878cd41e1" },
        { RoomSceneLocations.FRONTIER_SQUADS, "253fa009-6e65-4c90-91a1-7137a56a267f" },
        { RoomSceneLocations.CRESCENDO_OF_THE_BLOOD_MOON, "49cb8993-a956-43e2-86f4-1318f279b22a" },
        { RoomSceneLocations.BOWLING_ALLEY, "ae929543-9a07-41d5-8ee9-dbbee8c36800" },
        { RoomSceneLocations.ANIMATION_RECORDING_STUDIO, "a95c349c-0f96-4c2d-a4c8-4969ffa8ea44" },
        { RoomSceneLocations.STUNTRUNNER, "b7281665-a715-4051-826b-8e08e69c6172" },
        { RoomSceneLocations.STUNTRUNNER_THE_MAIN_EVENT, "3a636bd2-f896-424c-9225-c184522c0d87" },
        { RoomSceneLocations.STUNTRUNNER_BASE_ROOM, "882e9b96-7115-4b03-86f6-c0c9d8e22e00" },
        { RoomSceneLocations.REGISTRATION, "cf61556d-68fd-4288-9ae5-7a512621e569" },
        { RoomSceneLocations.AR_ROOM, "bf268f5f-b55b-41af-8628-32fa4b5d70b6" },
        { RoomSceneLocations.DRIVEIN, "65ddbb48-5a01-4e3e-972d-e5c7419e2bc3" },
        { RoomSceneLocations.CHARADES_THE_INK_SPACE, "a673712c-877f-4749-b69a-4a4c6310d545" },
        { RoomSceneLocations.THE_INK_SPACE_BASE_ROOM, "1fa06e3c-c307-4c11-a91b-1fabcddb8a96" },
        { RoomSceneLocations.FRONTIER_UGC, "a16bfd31-ffb9-46ac-a199-362c163130c0" },
        
    };
    public RequiredRoomSceneLocationChallenge()
    {
    }

    public RequiredRoomSceneLocationChallenge(List<RoomSceneLocations> values)
    {
        Values = values;
    }

    public RequiredRoomSceneLocationChallenge(List<RoomSceneLocations> values, bool inclusive)
    {
        Values = values;
        Inclusive = inclusive;
    }

    public RequiredRoomSceneLocationChallenge(List<RoomSceneLocations> values, bool inclusive, bool excludesIncludesNull)
    {
        Values = values;
        Inclusive = inclusive;
        ExcludesIncludesNull = excludesIncludesNull;
    }

    public RequiredRoomSceneLocationChallenge(RoomSceneLocations value) : this(new List<RoomSceneLocations>() { value }){}
    public RequiredRoomSceneLocationChallenge(RoomSceneLocations value, bool inclusive) : this(new List<RoomSceneLocations>(){value},  inclusive){}
    public RequiredRoomSceneLocationChallenge(RoomSceneLocations value, bool inclusive, bool excludesIncludesNull) : this(new List<RoomSceneLocations>(){value},  inclusive, excludesIncludesNull){}
}