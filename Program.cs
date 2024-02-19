using Microsoft.EntityFrameworkCore;
using RestAPIcurso.Business;
using RestAPIcurso.Business.Implementations;
using RestAPIcurso.Hypermedia.Enricher;
using RestAPIcurso.Hypermedia.Filters;
using RestAPIcurso.Model.Context;
using RestAPIcurso.Repository;
using RestAPIcurso.Repository.Generic;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];
builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 29))));

// Add services to the container.
var filterOptions = new HyperMediaFilterOptions();
filterOptions.ContentResponseEnricherList.Add(new PersonEnricher());

builder.Services.AddSingleton(filterOptions);

builder.Services.AddControllers();

builder.Services.AddApiVersioning();

builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapControllerRoute("DefaultApi", "{controller=values}/v{version=apiVersion}/{id?}");

app.Run();

