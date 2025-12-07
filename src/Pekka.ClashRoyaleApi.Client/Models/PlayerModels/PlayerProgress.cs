using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Pekka.ClashRoyaleApi.Client.Models.PlayerModels
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PlayerProgress : Dictionary<string, PlayerProgressItem>
    {
        // Questa classe estende Dictionary per gestire le chiavi dinamiche
        // come "" e "AutoChess_2025_Dec" nel JSON
    }
}
