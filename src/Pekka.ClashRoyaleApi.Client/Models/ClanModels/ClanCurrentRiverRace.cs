using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Pekka.ClashRoyaleApi.Client.Contracts.Models;
using Pekka.Core.JsonConverters;

namespace Pekka.ClashRoyaleApi.Client.Models.ClanModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ClanCurrentRiverRace
    {
        public string State { get; set; }

        public string WarEndTime { get; set; }
        public string CollectionEndTime { get; set; }
        public int SectionIndex { get; set; }
        public int PeriodIndex { get; set; }
        public string PeriodType { get; set; }
        [JsonConverter(typeof(CustomConverter<ClanCurrentRiverRacePeriodLog[]>))] 
        public ClanCurrentRiverRacePeriodLog[] PeriodLogs { get; set; }

        [JsonConverter(typeof(CustomConverter<ClanCurrentRiverRaceClan>))]
        public ClanCurrentRiverRaceClan Clan { get; set; }

        [JsonConverter(typeof(CustomConverter<ClanCurrentRiverRaceClan[]>))]
        public ClanCurrentRiverRaceClan[] Clans { get; set; }

    }
}
