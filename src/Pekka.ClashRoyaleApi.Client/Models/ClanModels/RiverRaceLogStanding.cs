using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Pekka.ClashRoyaleApi.Client.Contracts.Models;
using Pekka.Core.JsonConverters;


namespace Pekka.ClashRoyaleApi.Client.Models.ClanModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class RiverRaceLogStanding
    {
        [JsonConverter(typeof(CustomConverter<RiverRaceLogClan>))]
        public RiverRaceLogClan Clan { get; set; }

        public int TrophyChange { get; set; }

        public int Rank { get; set; }
    }
}