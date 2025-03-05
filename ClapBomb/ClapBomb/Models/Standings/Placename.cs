using System.Text.Json.Serialization;

namespace ClapBomb.Models.Standings;

public class Placename
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
    public string fr { get; set; }
}
