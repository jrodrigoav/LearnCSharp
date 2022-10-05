using System.Text.Json.Serialization;

namespace LearnCSharp.Module3.Models
{
    public class Comments
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("postId")]
        public int PostId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}
