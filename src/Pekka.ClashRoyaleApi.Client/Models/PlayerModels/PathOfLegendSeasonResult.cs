using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Pekka.ClashRoyaleApi.Client.Models.PlayerModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PathOfLegendSeasonResult
    {
        public int? Trophies { get; set; }
        
        public int? Rank { get; set; }
        
        public int? LeagueNumber { get; set; }
    }
}
