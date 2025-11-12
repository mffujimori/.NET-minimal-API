using Microsoft.EntityFrameworkCore;
using Random_Forest.Data;
using Random_Forest.Routes;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));

var app = builder.Build();

CustomerRoute.CustomerRoutes(app);

app.UseHttpsRedirection();
app.Run();



