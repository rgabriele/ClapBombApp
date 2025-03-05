using System.Text.Json.Serialization;

namespace ClapBomb.Models.GameLog;

public class Commonname
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
}
