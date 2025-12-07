using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Pekka.ClashRoyaleApi.Client.Models.PlayerModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PlayerProgressItem
    {
        public PlayerProgressArena Arena { get; set; }
        
        public int Trophies { get; set; }
        
        public int BestTrophies { get; set; }
    }
}
