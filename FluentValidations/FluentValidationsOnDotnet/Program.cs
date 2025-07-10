using FluentValidation;
using FluentValidationsOnDotnet;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddScoped<IValidator<Customer>, CustomerValidator>();
builder.Services.AddValidatorsFromAssemblyContaining(typeof(WeatherForecast));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
