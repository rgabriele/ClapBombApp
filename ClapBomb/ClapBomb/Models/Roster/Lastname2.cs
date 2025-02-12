using System.Text.Json.Serialization;

namespace ClapBomb.Models.Roster;

public class Lastname2
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
}
