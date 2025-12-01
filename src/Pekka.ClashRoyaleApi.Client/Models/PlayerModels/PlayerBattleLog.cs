using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Pekka.ClashRoyaleApi.Client.Models.PlayerModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PlayerBattleLog
    {
        public string Type { get; set; }

        public string BattleTime { get; set; }

        public string BoatBattleSide { get; set; }
        public bool BoatBattleWon { get; set; }

        public bool IsLadderTournament { get; set; }
        public bool IsHostedMatch { get; set; }

        public PlayerBattleLogArena Arena { get; set; }

        public PlayerBattleLogGameMode GameMode { get; set; }

        public string DeckSelection { get; set; }

        public PlayerBattleLogTeam[] Team { get; set; }

        public PlayerBattleLogTeam[] Opponent { get; set; }

        public string ChallengeTitle { get; set; }
        public string TournamentTag { get; set; }

        public int? ChallengeId { get; set; }

        public int? ChallengeWinCountBefore { get; set; }
        public int NewTowersDestroyed { get; set; }
        public int PrevTowersDestroyed { get; set; }
        public int RemainingTowers { get; set; }

    }
}