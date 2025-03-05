using System.Text.Json.Serialization;

namespace ClapBomb.Models.PlayerInfo;

public class Trophy
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
    public string fr { get; set; }
}
