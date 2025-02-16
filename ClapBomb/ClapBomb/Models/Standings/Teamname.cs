using System.Text.Json.Serialization;

namespace ClapBomb.Models.Rankings;

public class Teamname
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
    public string fr { get; set; }
}
