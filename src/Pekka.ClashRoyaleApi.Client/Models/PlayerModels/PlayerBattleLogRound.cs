using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Pekka.ClashRoyaleApi.Client.Models.PlayerModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PlayerBattleLogRound
    {

        public int Crowns { get; set; }

        public int KingTowerHitPoints { get; set; }

        public int[] PrincessTowersHitPoints { get; set; }

        public double ElixirLeaked { get; set; }

        public PlayerBattleLogCard[] Cards { get; set; }
    }
}