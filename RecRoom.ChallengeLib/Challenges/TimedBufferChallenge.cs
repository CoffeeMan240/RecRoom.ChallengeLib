using System.Globalization;
using RecRoom.ChallengeLib.ChallengeEvents;
using RecRoom.ChallengeLib.Enums;
using RecRoom.ChallengeLib.Interfaces;

namespace RecRoom.ChallengeLib.Challenges;

public class TimedBufferChallenge : Challenge
{
    public override ChallengeTypes ChallengeType { get; } = ChallengeTypes.TimedBufferChallenge;

    public override Dictionary<string, object> Serialize()
    {
        var dictionary = base.Serialize();
        var counts = new List<Dictionary<string, object>>();
        foreach (var challenge in ChallengesToCount)
        {
            counts.Add(challenge.Serialize());
        }
        dictionary.Add("ccc", counts);
        dictionary.Add("i", CultureInfo.CurrentCulture);
        dictionary.Add("t", Total);
        dictionary.Add("pm", ProgressMode);
        if (NotificationCounts.Count > 0)
        {
            dictionary.Add("n", NotificationCounts);
        }
        dictionary.Add("pb", PersistBuffer);
        if (BufferCountMethods != BufferCountMethods.Count)
        {
            dictionary.Add("m", BufferCountMethods);
        }

        return dictionary;
    }
    public TimedBufferChallenge(){}

    public TimedBufferChallenge(List<IChallenge> challengesToCount, int total,
        TimedBufferChallengeProgressMode progressMode = TimedBufferChallengeProgressMode.Complete,
        List<int> notificationCounts = null, bool persistBuffer = false,
        BufferCountMethods bufferCountMethods = BufferCountMethods.Count)
    {
        ChallengesToCount = challengesToCount;
        Total = total;
        ProgressMode = progressMode;
        NotificationCounts = notificationCounts;
        PersistBuffer = persistBuffer;
        BufferCountMethods = bufferCountMethods;
    }
    
    public List<IChallenge> ChallengesToCount { get; set; }
    public int Total { get; set; }
    public TimedBufferChallengeProgressMode ProgressMode { get; set; }
    public List<int> NotificationCounts { get; set; }
    public bool PersistBuffer { get; set; }
    public BufferCountMethods  BufferCountMethods { get; set; }
    //public List<TimedBufferEntry> BufferEntries { get; set; }
}

public struct TimedBufferEntry
{
    public float Time { get; set; }
    public ChallengeEventData EventData { get; set; }

    public Dictionary<string, object> Serialize()
    {
        var dictionary = new Dictionary<string, object>();
        dictionary.Add("t", Time);
        dictionary.Add("e", EventData);
        return dictionary;
    }
}