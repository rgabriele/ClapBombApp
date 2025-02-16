using System.Text.Json.Serialization;

namespace ClapBomb.Models.Standings;

public class Teamabbrev
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
}
