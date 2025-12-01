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
    public class ClanCurrentRiverRacePeriodLogEntry
    {
        [JsonConverter(typeof(CustomConverter<ClanCurrentRiverRacePeriodLogEntryClan>))] 
        public ClanCurrentRiverRacePeriodLogEntryClan Clan { get; set; }
        public int PointsEarned { get; set; }
        public int ProgressStartOfDay { get; set; }
        public int ProgressEndOfDay { get; set; }
        public int EndOfDayRank { get; set; }
        public int ProgressEarned { get; set; }
        public int NumOfDefensesRemaining { get; set; }
        public int ProgressEarnedFromDefenses { get; set; }
    }
}