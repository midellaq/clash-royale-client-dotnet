using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Pekka.ClashRoyaleApi.Client.Contracts.Models;
using Pekka.Core.JsonConverters;

namespace Pekka.ClashRoyaleApi.Client.Models.PlayerModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PlayerBadge
    {
        public string Name { get; set; }

        public int Progress { get; set; }

        public int? Level { get; set; }

        public int? MaxLevel { get; set; }

        public int? Target { get; set; }

        [JsonConverter(typeof(CustomConverter<PlayerIconUrl>))]
        public IIconUrl IconUrls { get; set; }
    }
}