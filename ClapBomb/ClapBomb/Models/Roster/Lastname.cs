using System.Text.Json.Serialization;

namespace ClapBomb.Models.Roster;

public class Lastname
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
    public string cs { get; set; }
    public string fi { get; set; }
    public string sk { get; set; }
}
