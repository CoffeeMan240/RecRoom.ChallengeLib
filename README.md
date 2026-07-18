# RecRoom.ChallengeLib
This library replicates the date structure that Rec Room Weekly Challenge Configs use. This data was reverse engeneered from the 20200306 version of Rec Room, with data types from 20210813. No reason in particular, just had the builds at the time XD.
  
# Usage
## Basic Challenge
For many cases, you'd wanna build a regular challenge. Use ChallengeBuilder to do that! For basic count challenges (for progress on the thing), use ChallengeCountChallengeBuilder!
Example with RequiredRoomSceneLocationChallenge
```CSharp
public Dictionary<string, object> GenerateBasicChallenge()
{
    return ChallengeBuilder.CreateBuilder()
      .WithCondition(new RequiredRoomSceneLocationChallenge(RoomSceneLocations.REC_CENTER))
      .Build();
}
```
## Reset Conditions
Use these to reset a challenges progress. For example, get 10 hits in the same game of Paintball on the River map
```CSharp
public Dictionary<string, object> GenerateOneGamePaintball()
{
    return ChallengeCountChallengeBuilder.CreateBuilder(10)
      .WithCondition(new RequiredRoomSceneLocationChallenge(RoomSceneLocations.RIVER))
      .ResetCondition(new RequiredEventTypeChallenge(ChallengeEventTypes.GameEnd))
      .Build();
}
```
## "Macros"
Many challenges are just "macros", or just challenges that add others. These require DRAMATICLY less work. For example, hitstreaks
```CSharp
public Dictionary<string, object> GenerateHitstreakChallenge()
{
    return new HitstreakCountChallenge(3, 5);
}
```
Of course, youd want more control, like hitstreaks in paintball maps (see [Reset Conditions](https://github.com/CoffeeMan240/RecRoom.ChallengeLib#reset-conditions))
## Serializing
You can simply use most serializers, as it just is a Dictionary<string, object>(). Rec Room expects it as a string anyways.

