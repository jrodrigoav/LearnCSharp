using System.Text.Json.Serialization;

namespace LearnCSharp.Module3.Models
{
    public class Company
    {
        [JsonPropertyName("name")]
        public string NameWork { get; set; }
        
        [JsonPropertyName("catchPhrase")]
        public string CatchPhrase { get; set; }
        
        [JsonPropertyName("bs")]
        public string Bs { get; set; }
    }
}
