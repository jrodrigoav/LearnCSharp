using LearnCSharp.Module3.Models;
using Microsoft.Extensions.Options;

namespace LearnCSharp.Module3
{
    public interface IUsersService : IJsonPlaceholderService<User>
    {
    }
    public class UsersService : JsonplaceholderBaseService, IUsersService
    {
        public UsersService(HttpClient client, IOptionsMonitor<JsonplaceholderSettings> optionsMonitor) : base(client, optionsMonitor)
        {

        }

        public async Task<User[]> GetAllAsync()
        {
            var users = await _client.GetFromJsonAsync<User[]>("users");
            return users ?? Array.Empty<User>();
        }
    }

}