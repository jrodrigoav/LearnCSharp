using LearnCSharp.Module3.Models;
using Microsoft.Extensions.Options;

namespace LearnCSharp.Module3
{
    public class JsonplaceholderService : IJsonplaceholderService
    {
        private readonly HttpClient _client;

        public JsonplaceholderService(HttpClient client, IOptionsMonitor<JsonplaceholderSettings> optionsMonitor)
        {
            _client = client;
            _client.BaseAddress = new Uri(optionsMonitor.CurrentValue.Url);
        }

        public async Task<Post[]> GetPostsAsync()
        {
            var posts = await _client.GetFromJsonAsync<Post[]>("posts");
            return posts ?? Array.Empty<Post>();
        }
    }
}