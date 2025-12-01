using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Pekka.ClashRoyaleApi.Client.Contracts.Models;

using Pekka.Core.JsonConverters;

namespace Pekka.ClashRoyaleApi.Client.Models.ClanModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class RiverRaceLogClan : IRiverRaceClanSummary
    {
        public string Tag { get; set; }

        public string Name { get; set; }

        public int BadgeId { get; set; }

        public int ClanScore { get; set; }

        [JsonConverter(typeof(CustomConverter<RiverRaceLogParticipant[]>))]
        public IRiverRaceParticipant[] Participants { get; set; }

        public int BattlesPlayed { get; set; }

        public int Wins { get; set; }

        public int Crowns { get; set; }
        public int Fame { get; set; }
        public int RepairPoints { get; set; }
        public int PeriodPoints { get; set; }
        public string FinishTime { get; set; }
    }
}