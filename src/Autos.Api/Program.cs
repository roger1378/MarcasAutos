using Autos.Api.Configuration;
using Autos.Api.Extensions;
using Autos.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add configuration for connection string
var connectionString = builder.Configuration.GetConnectionString("ApplicationDb");
builder.Services.AddDbContext<AutosMarcasDbContext>(options =>
options.UseNpgsql(connectionString));

builder.Services
    .AddMappers()
    .AddMyDependencyGroup();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
