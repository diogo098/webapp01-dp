var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World by AWS CESAE Diogo!");

app.Run();
