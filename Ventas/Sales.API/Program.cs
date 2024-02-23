using Microsoft.EntityFrameworkCore;
using Sales.API.Data;

var builder = WebApplication.CreateBuilder(args);

//Agregar servicios al contenedor
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer("name=DockerConnection"));

var app = builder.Build();

