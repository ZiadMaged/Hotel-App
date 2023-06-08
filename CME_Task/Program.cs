using CME_Task.ActionFilters;
using CME_Task.Data;
using CME_Task.Extentions;
using CME_Task.Models;
using CME_Task.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.CustomCorsAddition();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

string? connectionString = builder.Configuration.GetConnectionString("HotelConectionString");
builder.Services.AddDbContext<HotelDbContext>(opt => opt.UseSqlServer(connectionString));

builder.Services.ConfigureScoped();
builder.Services.AddAutoMapper(typeof(Program).Assembly);


var app = builder.Build();

app.ConfigureCors();
app.ConfigureMiddlewareException();
app.MapControllers();

app.Run();
