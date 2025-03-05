using System.Text.Json.Serialization;

namespace ClapBomb.Models.PlayerInfo;

public class Birthstateprovince
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
}
