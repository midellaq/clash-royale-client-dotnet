using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Pekka.ClashRoyaleApi.Client.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardRarity
    {
        [EnumMember(Value = "common")]
        Common,

        [EnumMember(Value = "rare")]
        Rare,

        [EnumMember(Value = "epic")]
        Epic,

        [EnumMember(Value = "legendary")]
        Legendary,

        [EnumMember(Value = "champion")]
        Champion
    }
}
