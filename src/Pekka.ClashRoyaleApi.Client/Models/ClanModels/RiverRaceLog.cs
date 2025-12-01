using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Pekka.ClashRoyaleApi.Client.Contracts.Models;
using Pekka.Core.JsonConverters;

namespace Pekka.ClashRoyaleApi.Client.Models.ClanModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class RiverRaceLog
    {
        public int SeasonId { get; set; }

        public string CreatedDate { get; set; }

        public int SectionIndex { get; set; }

        public RiverRaceLogStanding[] Standings { get; set; }
    }
}