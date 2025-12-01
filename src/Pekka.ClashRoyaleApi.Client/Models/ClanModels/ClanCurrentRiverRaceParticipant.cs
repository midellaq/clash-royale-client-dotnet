using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Pekka.ClashRoyaleApi.Client.Contracts.Models;

namespace Pekka.ClashRoyaleApi.Client.Models.ClanModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ClanCurrentRiverRaceParticipant : IRiverRaceParticipant
    {
        public string Tag { get; set; }

        public string Name { get; set; }

        public int Fame { get; set; }
        public int RepairPoints { get; set; }
        public int BoatAttacks { get; set; }

        public int DecksUsed { get; set; }

        public int DecksUsedToday { get; set; }
    }
}