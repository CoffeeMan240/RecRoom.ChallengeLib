using Newtonsoft.Json;
using RecRoom.ChallengeLib;
using RecRoom.ChallengeLib.Challenges;
using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RR2021ChallengeGenerator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var builder = ChallengeBuilder.CreateBuilder();
        builder
            .WithCondition(new RequiredEnemyTypeChallenge(new List<EnemyTypes>() { EnemyTypes.QUEST_GOBLIN_BASIC_GROUND_MELEE }))
            .WithCondition(new RequiredRoomSceneLocationChallenge(new List<RoomSceneLocations>()
            {
                RoomSceneLocations.QUEST_FOR_THE_GOLDEN_TROPHY
            }));
        var challenge = builder.Build();
        var ccc = new ChallengeCountChallenge(5, new List<IChallenge>()
        {
            challenge,
        });
        Console.WriteLine(JsonConvert.SerializeObject(ccc.Serialize()));
    }
}