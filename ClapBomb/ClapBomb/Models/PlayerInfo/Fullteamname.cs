using System.Text.Json.Serialization;

namespace ClapBomb.Models.PlayerInfo;

public class Fullteamname
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
    public string fr { get; set; }
}
