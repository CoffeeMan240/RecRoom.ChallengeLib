namespace RecRoom.ChallengeLib.Data;

public class EventsVars
{
    public class GameEventData
    {
        /// string, id of the game.
        public const string GameId = "gid"; 
        /// LegacyGameModeType as int, the game mode.
        public const string GameMode = "gameMode"; 
        /// int, the team members of your team.
        public const string NumTeammates = "numTeammates";
        /// float, score of your team
        public const string TeamScore = "t_score";
    }
    public class GameStarted : GameEventData
    {
        /// bool, denotes if you joined in the middle of it.
        public const string JoinInProgress = "jip";
        /// Bool, denotes if you're spectating.
        public const string IsSpectator = "isSpectator";
    }
    
    public class GameEnded : GameEventData
    {
        /// float, how long the game lasted.
        public const string TimeElasped = "te";
        /// bool, did the player win? (used in quests)
        public const string Won = "won";
    }

    public class Score : GameEventData
    {
        /// float, current score.
        public const string ScoreKey = "ev_score";
    }
    
    public class Enemy
    { 
        //int, photon view id of an enemy. 
        public const string EnemyPhotonViewId = "e_vid"; 
        //EnemyType as int, type of enemy.
        public const string EnemyType = "e_t";
    }

    public class Player
    {
        //int, photon view id of defending player.
        public const string DefendingPlayerPhotonViewId = "dp_vid";
        //int, Rec Net Player ID of defending player.
        public const string DefendingPlayerRecNetId = "dp_pid";
        
        //int, photon view id of attacking player.
        public const string AttackingPlayerPhotonViewId = "ap_vid";
        
        //int, Rec Net Player ID of attacking player.
        public const string AttackingPlayerRecNetId = "ap_pid";
    }
    ///Also outputs a tool used, as well as the attacker and defender.
    public class EliminatedOtherPlayer
    {
        //int, body part that was hit on the player eliminated.
        public const string BodyPart = "bodyPart";
    }

    public class Tool
    {
        //int, photon view id of defending player.
        public const string ToolPhotonViewId = "t_vid";
        //SpawnableToolType as int, type of tool.
        public const string ToolType = "t_t";
    }
    
    public class DiscGolfScore : Score
    {
        //int, number of strokes player took
        public const string StrokeCount = "strokeCount";
        //int, par of the hole.
        public const string HolePar = "par";
    }
    
}