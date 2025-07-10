using FluentValidation;
using FluentValidationsOnDotnet.Model;
using FluentValidationsOnDotnet.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IValidator<Customer>, CustomerValidator>();

builder.Services.AddControllers(); // or MapEndpoints for minimal API

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
