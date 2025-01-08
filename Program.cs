var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! \n WELCOME TO C# class Nita and Ibrahim");



app.Run();
