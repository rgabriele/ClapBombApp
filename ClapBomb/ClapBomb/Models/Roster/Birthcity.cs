using System.Text.Json.Serialization;

namespace ClapBomb.Models.Roster;

public class Birthcity
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
    public string fi { get; set; }
    public string sv { get; set; }
}
