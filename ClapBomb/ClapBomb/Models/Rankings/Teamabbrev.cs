using System.Text.Json.Serialization;

namespace ClapBomb.Models.Rankings
{
    public class Teamabbrev
    {
        [JsonPropertyName("default")]
        public string _default { get; set; }
    }

}
