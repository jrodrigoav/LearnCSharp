using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/users/{userId}/books/{bookId}",
//    (int userId, int bookId) => $"The user id is {userId} and book id is {bookId}");

//app.MapGet("/Nombre/{sayhello}",
//    (string sayhello) => $"Hola{sayhello}");

//app.MapGet("/products", (int? pageNumber) => $"Requesting page {pageNumber ?? 1}");

//string ListProducts(int pageNumber = 1) => $"Requesting page {pageNumber}";

//app.MapGet("/products2", ListProducts);

app.MapGet("/area/{Idarea:int:min(0)}", (double area, double Idarea) =>
{
    double radio = 2.5;
    area = Math.PI * radio * radio;
});


app.MapGet("/{x:int:min(0)}/{y:int:min(0)}/{z:int:min(0)}", (int x, int y, int z) =>
{
    var result = x + y ;
    if (result == z)
    {
        return "si sabes sumar"; 
    }
    else
    {
        return "El resultado es incorrecto";
    }
});


//app.MapGet("/{comida}", (string comida) =>
//{
//new List<string> { "Tacos", "Pizza", "Hamburguesa" }.Add("sushi");
//});
//comida.Add("sushi");
//
//comida.Sort();
//foreach (string comidas in comida)
//{
//    Console.WriteLine($"Quiero comer {comidas}");
//}

//Console.WriteLine(comida[1]);
//Console.WriteLine($"La lista tiene {comida.Count} comidas");
app.Run();

//    int x = 1, y = 5, z = 6;
//int result = x + y;
//if (result == z)
//{
//    Console.WriteLine("El resultado es correcto");
//}
//else
//{
//    Console.WriteLine("El resultado es incorrecto");
//}
//Console.WriteLine("");



