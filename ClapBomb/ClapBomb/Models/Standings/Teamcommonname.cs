using System.Text.Json.Serialization;

namespace ClapBomb.Models.Standings;

public class Teamcommonname
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
    public string fr { get; set; }
}
