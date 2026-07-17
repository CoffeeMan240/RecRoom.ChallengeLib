namespace RecRoom.ChallengeLib.Enums;

public enum ChallengeTypes
{
    Challenge,
    ChallengeCountChallenge,
    TimedBufferChallenge,
    DynamicFloatArithmeticChallenge, //clamplicated
    DynamicIntArithmeticChallenge, // see above
    RequiredToolChallenge,
    RequiredEventTypeChallenge,
    RequiredRoomSceneLocationChallenge,
    RequiredEnemyTypeChallenge,
    BoolVarEqualsChallenge, //theres nothing..
    DiscGolfFinishUnderParChallenge = 11,
    RequiredGameModeActivityChallenge,
    CompleteGameWithoutChallenge,
    RequiredGestureChallenge,
    HitstreakChallenge,
    HitstreakCountChallenge
}