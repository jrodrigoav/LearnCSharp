using System.Text.Json.Serialization;

namespace LearnCSharp.Module3.Models
{
    public class Albums
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
