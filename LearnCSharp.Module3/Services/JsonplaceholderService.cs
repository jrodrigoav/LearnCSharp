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

        public async Task<Todo[]> GetTodosAsync()
        {
            var todos = await _client.GetFromJsonAsync<Todo[]>("todos");
            return todos ?? Array.Empty<Todo>();
        }

        public async Task<User[]> GetUsersAsync()
        {
            var users = await _client.GetFromJsonAsync<User[]>("users");
            return users ?? Array.Empty<User>();
        }
        public async Task<Comment[]> GetCommentsAsync()
        {
            var comments = await _client.GetFromJsonAsync<Comment[]>("comments");
            return comments ?? Array.Empty<Comment>();
        }
        public async Task<Album[]> GetAlbumsAsync()
        {
            var albums = await _client.GetFromJsonAsync<Album[]>("albums");
            return albums ?? Array.Empty<Album>();
        }
        public async Task<Photo[]> GetPhotosAsync()
        {
            var photos = await _client.GetFromJsonAsync<Photo[]>("photos");
            return photos ?? Array.Empty<Photo>();
        }
    }
}