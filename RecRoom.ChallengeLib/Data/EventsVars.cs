namespace RecRoom.ChallengeLib.Data;

public class EventsVars
{
    public class GameEventData
    {
        /// <summary>
        /// string, id of the game.
        /// </summary>
        public const string GameId = "gid"; 
        /// <summary>
        /// LegacyGameModeType as int, the game mode.
        /// </summary>
        public const string GameMode = "gameMode"; 
        /// <summary>
        /// int, the team members of your team.
        /// </summary>
        public const string NumTeammates = "numTeammates";
        /// <summary>
        /// float, score of your team
        /// </summary>
        public const string TeamScore = "t_score";
    }
    public class GameStarted : GameEventData
    {
        /// <summary>
        /// bool, denotes if you joined in the middle of it.
        /// </summary>
        public const string JoinInProgress = "jip";
        /// <summary>
        /// Bool, denotes if you're spectating.
        /// </summary>
        public const string IsSpectator = "isSpectator";
    }
    
    public class GameEnded : GameEventData
    {
        /// <summary>
        /// float, how long the game lasted.
        /// </summary>
        public const string TimeElasped = "te";
        /// <summary>
        /// bool, did the player win? (used in quests)
        /// </summary>
        public const string Won = "won";
    }

    public class Score : GameEventData
    {   
        /// <summary>
        /// float, current score.
        /// </summary>
        public const string ScoreKey = "ev_score";
    }
    
    public class Enemy
    { 
        ///<summary>
        ///int, photon view id of an enemy.
        /// </summary>
        public const string EnemyPhotonViewId = "e_vid"; 
        ///<summary>
        ///EnemyType as int, type of enemy.
        /// </summary>
        public const string EnemyType = "e_t";
    }

    public class Player
    {
        /// <summary>
        ///int, photon view id of defending player.
        /// </summary>
        public const string DefendingPlayerPhotonViewId = "dp_vid";
        /// <summary>
        ///int, Rec Net Player ID of defending player.
        /// </summary>
        public const string DefendingPlayerRecNetId = "dp_pid";
        /// <summary>
        ///int, photon view id of attacking player.
        /// </summary>
        public const string AttackingPlayerPhotonViewId = "ap_vid";
        /// <summary>
        ///int, Rec Net Player ID of attacking player.
        /// </summary>
        public const string AttackingPlayerRecNetId = "ap_pid";
    }
    /// <summary>
    ///Also outputs a tool used, as well as the attacker and defender.
    /// </summary>
    public class EliminatedOtherPlayer
    {
        /// <summary>
        ///int, body part that was hit on the player eliminated.
        /// </summary>
        public const string BodyPart = "bodyPart";
    }

    public class Tool
    {
        /// <summary>
        ///int, photon view id of defending player.
        /// </summary>
        public const string ToolPhotonViewId = "t_vid";
        /// <summary>
        ///SpawnableToolType as int, type of tool.
        /// </summary>
        public const string ToolType = "t_t";
    }
    
    public class DiscGolfScore : Score
    {
        /// <summary>
        ///int, number of strokes player took
        /// </summary>
        public const string StrokeCount = "strokeCount";
        /// <summary>
        ///int, par of the hole.
        /// </summary>
        public const string HolePar = "par";
    }
    
}