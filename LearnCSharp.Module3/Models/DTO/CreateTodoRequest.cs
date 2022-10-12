using System.Text.Json.Serialization;

namespace LearnCSharp.Module3.Models.DTO
{
    public class CreateTodoRequest
    {
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        
        [JsonPropertyName("title")]
        public string Title { get; set; } = null!;
        
        [JsonPropertyName("completed")]
        public bool Completed { get; set; }
    }
}
