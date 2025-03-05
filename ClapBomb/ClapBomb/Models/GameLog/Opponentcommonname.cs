using System.Text.Json.Serialization;

namespace ClapBomb.Models.GameLog;

public class Opponentcommonname
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
    public string fr { get; set; }
}
