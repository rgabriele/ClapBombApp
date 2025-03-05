using System.Text.Json.Serialization;

namespace ClapBomb.Models.PlayerInfo;

public class Birthcity
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
}
