using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/users/{userId}/books/{bookId}",
    (int userId, int bookId) => $"The user id is {userId} and book id is {bookId}");

app.MapGet("/Nombre/{sayhello}",
    (string sayhello) => $"Hola{sayhello}");

app.MapGet("/products", (int? pageNumber) => $"Requesting page {pageNumber ?? 1}");

string ListProducts(int pageNumber = 1) => $"Requesting page {pageNumber}";

app.MapGet("/products2", ListProducts);

app.MapGet("/area/{Idarea:double:min(0)}", (double area, double Idarea) =>
{
    double radio = 2.5;
    area = Math.PI * radio * radio;
});


app.MapGet("/{x:int:min(0)}/{y:int:min(0)}/{z:int:min(0)}", (int x, int y, int z) =>
{
    var result = x + y;
    if (result == z)
    {
        return "si sabes sumar";
    }
    else
    {
        return "El resultado es incorrecto";
    }
});

app.MapGet("/hello", (string name) => ($"Hola {name}"));
app.MapGet("/hello2/{name}/{lastname}",
    (string name, string lastname) => ($"Hola {name} {lastname}"));

app.MapGet("response", async () =>
{
    HttpClient client = new HttpClient();
    var response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/");
    response.EnsureSuccessStatusCode();
    string responseBody = await response.Content.ReadAsStringAsync();
    return responseBody;
});

app.Run();




