using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Pekka.ClashRoyaleApi.Client.Models.PlayerModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PlayerLeagueStatistics
    {
        public PlayerSeasonResults CurrentSeason { get; set; }

        public PlayerSeasonResults PreviousSeason { get; set; }

        public PlayerSeasonResults BestSeason { get; set; }
    }
}