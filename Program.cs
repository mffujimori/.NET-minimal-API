using Microsoft.EntityFrameworkCore;
using Random_Forest.Data;
using Random_Forest.Data.Interfaces;
using Random_Forest.Data.Repositories;
using Random_Forest.Routes;
using Random_Forest.Services;
using Random_Forest.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(connectionString)
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IHolderRepository, HolderRepository>();

builder.Services.AddScoped<IHolderService, HolderService>();


var app = builder.Build();

//swagger só em development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

HolderRoute.HolderRoutes(app);

//rota teste
app.MapGet("/", () => "");

app.Run();