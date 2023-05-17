 using Microsoft.OpenApi.Models;
using System.Configuration;
using Shared.InfraStructure.Extensions;
using Module.Catalog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCatalogModule(builder.Configuration);



builder.Services.AddSharedInfrastructure(builder.Configuration);
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
});



var app = builder.Build();



//var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
app.UseSwagger();
app.UseSwaggerUI();
}

//var summaries = new[]
//{
//    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//};

//app.MapGet("/weatherforecast", () =>
//{
//var forecast = Enumerable.Range(1, 5).Select(index =>
//   new WeatherForecast
//   (
//       DateTime.Now.AddDays(index),
//       Random.Shared.Next(-20, 55),
//       summaries[Random.Shared.Next(summaries.Length)]
//   ))
//    .ToArray();
//return forecast;
//})
//.WithName("GetWeatherForecast");
app.MapControllers();
app.Run();

//internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
//{
//    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}