using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// open api ekledik
builder.Services.AddOpenApi();
var app = builder.Build();

app.MapControllers();
app.MapOpenApi();
// open ai den gelen json'� g�rselle�tiriyor.
app.MapScalarApiReference();
app.Run();
