using Microsoft.EntityFrameworkCore;
using RestAPIcurso.Model.Context;
using RestAPIcurso.Services;
using RestAPIcurso.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];
builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(
    connection,
    new MySqlServerVersion(new Version(8, 0, 29)))
    );

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddScoped<IPersonServices, PersonServiceImplementation>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
