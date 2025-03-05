using System.Text.Json.Serialization;

namespace ClapBomb.Models.PlayerInfo;

public class Teamcommonname
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
}
