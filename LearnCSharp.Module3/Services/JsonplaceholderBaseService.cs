using LearnCSharp.Module3.Models;
using Microsoft.Extensions.Options;

namespace LearnCSharp.Module3
{
    public abstract class JsonplaceholderBaseService
    {
        protected readonly HttpClient _client;

        public JsonplaceholderBaseService(HttpClient client, IOptionsMonitor<JsonplaceholderSettings> optionsMonitor)
        {
            _client = client;
            _client.BaseAddress = new Uri(optionsMonitor.CurrentValue.Url);
        }
    }
}