using LearnCSharp.Module3.Models;
using Microsoft.Extensions.Options;

namespace LearnCSharp.Module3
{
    public interface ITodosService : IJsonPlaceholderService<Todo>
    {
    }

    public class TodosService : JsonplaceholderBaseService, ITodosService
    {
        public TodosService(HttpClient client, IOptionsMonitor<JsonplaceholderSettings> optionsMonitor) : base(client, optionsMonitor)
        {

        }

        public async Task<Todo[]> GetAllAsync()
        {
            var todos = await _client.GetFromJsonAsync<Todo[]>("todos");
            return todos ?? Array.Empty<Todo>();
        }
    }

}