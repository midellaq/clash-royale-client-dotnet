using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Pekka.ClashRoyaleApi.Client.Contracts.Models;
using Pekka.ClashRoyaleApi.Client.Models;
using Pekka.Core.JsonConverters;

namespace Pekka.ClashRoyaleApi.Client.Models.PlayerModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PlayerCard : ICard
    {
        public string Name { get; set; }

        public int Id { get; set; }
        public CardRarity Rarity { get; set; }

        public int Level { get; set; }

        public int StarLevel { get; set; }
        
        public int EvolutionLevel { get; set; }
        
        public int MaxEvolutionLevel { get; set; }
        
        public int ElixirCost { get; set; }
        
        public bool Used { get; set; }

        public int MaxLevel { get; set; }

        public int Count { get; set; }

        [JsonConverter(typeof(CustomConverter<PlayerIconUrl>))]
        public IIconUrl IconUrls { get; set; }
    }
}