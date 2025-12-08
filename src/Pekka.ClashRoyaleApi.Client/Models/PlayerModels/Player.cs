using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Pekka.ClashRoyaleApi.Client.Models.PlayerModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Player
    {
        public string Tag { get; set; }

        public string Name { get; set; }

        public int ExpLevel { get; set; }

        public int ExpPoints { get; set; }
        public int TotalExpPoints { get; set; }
        public int StarPoints { get; set; }
        public int Trophies { get; set; }
        
        public int? LegacyTrophyRoadHighScore { get; set; }
        public int BestTrophies { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int BattleCount { get; set; }

        public int ThreeCrownWins { get; set; }

        public int ChallengeCardsWon { get; set; }

        public int ChallengeMaxWins { get; set; }

        public int TournamentCardsWon { get; set; }

        public int TournamentBattleCount { get; set; }

        public string Role { get; set; }

        public int Donations { get; set; }

        public int DonationsReceived { get; set; }

        public int TotalDonations { get; set; }

        public int WarDayWins { get; set; }

        public int ClanCardsCollected { get; set; }

        public PlayerClan Clan { get; set; }

        public PlayerArena Arena { get; set; }

        public PlayerLeagueStatistics LeagueStatistics { get; set; }

        public PlayerBadge[] Badges { get; set; }

        public PlayerAchievement[] Achievements { get; set; }

        public PlayerCard[] Cards { get; set; }
        
        public PlayerCard[] SupportCards { get; set; }

        public PlayerCard[] CurrentDeck { get; set; }

        public PlayerCard[] CurrentDeckSupportCards { get; set; }

        public PlayerCurrentFavoriteCard CurrentFavouriteCard { get; set; }
        
        public PathOfLegendSeasonResult CurrentPathOfLegendSeasonResult { get; set; }  
        public PathOfLegendSeasonResult LastPathOfLegendSeasonResult { get; set; }  
        public PathOfLegendSeasonResult BestPathOfLegendSeasonResult { get; set; } 
        
        public PlayerProgress Progress { get; set; }
    }
}