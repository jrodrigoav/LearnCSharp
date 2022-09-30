using Serilog;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();


var Logger = new LoggerConfiguration()
.MinimumLevel.Information()
   .WriteTo.Console(theme: AnsiConsoleTheme.Code)
   .WriteTo.File(@"C:\\log\\serilog.txt")
   .CreateLogger();

builder.Logging.AddSerilog(Logger);
Log.Logger = Logger;
var app = builder.Build();

app.MapGet("response", async  (ILoggerFactory loggerFactory) =>
{
    var logger = loggerFactory.CreateLogger("EjercicioSR");
    try
    {

       
        HttpClient client = new HttpClient();
        logger.LogInformation("llamando al web service");
        var response = await client.GetAsync("https://jsonplaceholder.typicode.com/users/1");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        logger.LogInformation("eres chilo");


        return responseBody;
    }
    catch (Exception e)
    {
        logger.LogError(e.Message);
        throw;
    }
});
app.Run();
