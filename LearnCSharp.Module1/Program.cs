var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hola mustang");
app.MapGet("/{operacion:alpha}/{a:int:min(0)}/{b:int:min(0)}", (string operacion, int a , int b ) => { 
    if(operacion == "suma")
    {
        return a+b;
    }
    if(operacion == "multiplicacion")
    {
        return a*b;
    }
return 0;    
});
Console.WriteLine("Hola mundo mundial");
app.Run();
