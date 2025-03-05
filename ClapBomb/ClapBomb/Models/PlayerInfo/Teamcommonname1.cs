using System.Text.Json.Serialization;

namespace ClapBomb.Models.PlayerInfo;

public class Teamcommonname1
{
    [JsonPropertyName("default")]
    public string _default { get; set; }
    public string cs { get; set; }
    public string de { get; set; }
    public string es { get; set; }
    public string fi { get; set; }
    public string sk { get; set; }
    public string sv { get; set; }
}
