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

        public async Task<Todos[]> GetTodosAsync()
        {
            var todos = await _client.GetFromJsonAsync<Todos[]>("todos");
            return todos ?? Array.Empty<Todos>();
        }

        public async Task<Users[]> GetUsersAsync()
        {
            var users = await _client.GetFromJsonAsync<Users[]>("users");
            return users ?? Array.Empty<Users>();
        }
        public async Task<Comments[]> GetCommentsAsync()
        {
            var comments = await _client.GetFromJsonAsync<Comments[]>("comments");
            return comments ?? Array.Empty<Comments>();
        }
        public async Task<Albums[]> GetAlbumsAsync()
        {
            var albums = await _client.GetFromJsonAsync<Albums[]>("albums");
            return albums ?? Array.Empty<Albums>();
        }
        public async Task<Photos[]> GetPhotosAsync()
        {
            var photos = await _client.GetFromJsonAsync<Photos[]>("photos");
            return photos ?? Array.Empty<Photos>();
        }
    }
}