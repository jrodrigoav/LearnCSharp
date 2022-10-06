using System.Text.Json.Serialization;

namespace LearnCSharp.Module3.Models
{   public class Geo
    {
        [JsonPropertyName("lat")]
        public string Lat { get; set; }
        [JsonPropertyName("lng")]
        public string Lng { get; set; }
    }
}
