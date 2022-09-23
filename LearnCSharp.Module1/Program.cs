var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Facbook sucks");
app.MapGet("/suma", () => 1 + 1);
Console.WriteLine("Hola mundo mundial");
//app.Run();
