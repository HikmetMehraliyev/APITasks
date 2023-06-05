using ClassTaskAPI.DAL;
using ClassTaskAPI.Services.Implementations.Product;
using ClassTaskAPI.Services.Implementations.Restaurant;
using ClassTaskAPI.Services.Interfaces.ProductService;
using ClassTaskAPI.Services.Interfaces.RestaurantService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductService,.ProductService>();
builder.Services.AddScoped<IRestaurantService, RestaurantService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
