using Microsoft.EntityFrameworkCore;
using Project_2.Models;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddDbContext<DB33674590Context>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // "DefaultConnection" should match your connection string key


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext <DB33674590Context> ();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
