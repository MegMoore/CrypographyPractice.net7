using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CrypographyPractice.net7.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CrypographyPracticenet7Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CrypographyPracticenet7Context") ?? throw new InvalidOperationException("Connection string 'CrypographyPracticenet7Context' not found.")));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
