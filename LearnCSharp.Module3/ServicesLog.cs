namespace LearnCSharp.Module3
{
    public class ServicesLog : IServicesLog
    {
        private readonly IHttpClientFactory _servicesLog;

        public ServicesLog(IHttpClientFactory httpClientFactory)
        {
            _servicesLog = httpClientFactory;
        }

        public async Task Test(string user)
        {
            var client = _servicesLog.CreateClient();
            var result = await client.GetAsync(user);
            Console.WriteLine(result.StatusCode);
        }
       
    }
}
