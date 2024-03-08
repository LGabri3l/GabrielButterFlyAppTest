using GabrielButterfly.Core.Interfaces;
using GabrielButterfly.Core.Services;
using GabrielButterFly.API.Controllers;
using Microsoft.AspNetCore.Razor.TagHelpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAddition, AdditionService>();
builder.Services.AddScoped<ISubtraction, SubtractionService>();
builder.Services.AddScoped<IMultiplication, MultiplicationService>();
builder.Services.AddScoped<IDivision, DivisionService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
