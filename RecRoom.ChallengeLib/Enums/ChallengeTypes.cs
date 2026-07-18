namespace RecRoom.ChallengeLib.Enums;

public enum ChallengeTypes
{
    Challenge,
    ChallengeCountChallenge,
    TimedBufferChallenge,
    DynamicFloatArithmeticChallenge, //clamplicated
    DynamicIntArithmeticChallenge, // see above
    //RequiredToolChallenge, removed in radium 2021+, all that tool stuff for nothing ;-;
    RequiredEventTypeChallenge = 6,
    RequiredRoomSceneLocationChallenge,
    RequiredEnemyTypeChallenge,
    BoolVarEqualsChallenge,
    DiscGolfFinishUnderParChallenge = 11,
    RequiredGameModeActivityChallenge,
    CompleteGameWithoutChallenge,
    RequiredGestureChallenge,
    HitstreakChallenge,
    HitstreakCountChallenge
}