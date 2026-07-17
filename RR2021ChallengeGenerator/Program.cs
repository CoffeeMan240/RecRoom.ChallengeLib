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
        //kill 5 goblins in GT
        /*var builder = ChallengeBuilder.CreateBuilder();
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
        Console.WriteLine(JsonConvert.SerializeObject(ccc.Serialize()));*/
        var fakeHitStreak = new ChallengeCountChallenge(3, new List<IChallenge>(){new RequiredEventTypeChallenge(new List<ChallengeEventTypes>()
        {
            ChallengeEventTypes.EliminatedAI
        })});
        fakeHitStreak.ResetConditions.Add(new RequiredEventTypeChallenge(new List<ChallengeEventTypes>()
            {
                ChallengeEventTypes.LocalPlayerEliminated
            }));
        var count = new TimedBufferChallenge(new List<IChallenge>(){fakeHitStreak}, 20, -1);
        count.PersistBuffer = true;
        count.ProgressMode = TimedBufferChallengeProgressMode.Count;
        count.NotificationCounts.Add(5);
        count.NotificationCounts.Add(10);
        count.NotificationCounts.Add(15);
        count.WithConditions.Add(new RequiredRoomSceneLocationChallenge(new List<RoomSceneLocations>()
        {
            RoomSceneLocations.QUEST_FOR_THE_GOLDEN_TROPHY
        }));
        Console.WriteLine(JsonConvert.SerializeObject(count.Serialize()));
    }
    
}