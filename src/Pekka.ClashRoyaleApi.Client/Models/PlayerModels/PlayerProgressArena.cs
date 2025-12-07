using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Pekka.ClashRoyaleApi.Client.Models.PlayerModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PlayerProgressArena
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string RawName { get; set; }
    }
}
