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
    public class ClanCurrentRiverRacePeriodLog
    {
        public int PeriodIndex { get; set; }

        [JsonConverter(typeof(CustomConverter<ClanCurrentRiverRacePeriodLogEntry[]>))]
        public ClanCurrentRiverRacePeriodLogEntry[] Items { get; set; }
    }
}