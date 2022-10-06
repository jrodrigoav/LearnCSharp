using LearnCSharp.Module3;
using LearnCSharp.Module3.Models;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

Log.Information("Starting up");

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.Configure<JsonplaceholderSettings>(builder.Configuration.GetSection(nameof(JsonplaceholderSettings)));
    builder.Services.AddHttpClient<IJsonplaceholderService, JsonplaceholderService>();
    
    builder.Services.AddControllers();
    builder.Host.UseSerilog((ctx, lc) => lc
        .WriteTo.Console()
        .ReadFrom.Configuration(ctx.Configuration));
    var app = builder.Build();
    app.UseHttpsRedirection();
    app.UseStaticFiles();    
    app.UseSerilogRequestLogging();
    app.MapGet("/", () => "LearnCSharp.Module3");
    app.MapControllers();
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Unhandled exception");
}
finally
{
    Log.Information("Shut down complete");
    Log.CloseAndFlush();
}