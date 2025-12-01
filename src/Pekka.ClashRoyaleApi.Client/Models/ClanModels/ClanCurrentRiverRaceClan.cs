using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Pekka.ClashRoyaleApi.Client.Contracts.Models;
using Pekka.Core.JsonConverters;

namespace Pekka.ClashRoyaleApi.Client.Models.ClanModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ClanCurrentRiverRaceClan : IRiverRaceClanSummary
    {
        public string Tag { get; set; }

        public string Name { get; set; }

        public int BadgeId { get; set; }

        public int ClanScore { get; set; }

        public int Fame { get; set; }
        public int PeriodPoints { get; set; }
        public int RepairPoints { get; set; }
        public string FinishTime { get; set; }

        [JsonConverter(typeof(CustomConverter<ClanCurrentRiverRaceParticipant[]>))]
        public IRiverRaceParticipant[] Participants { get; set; }

    }
}