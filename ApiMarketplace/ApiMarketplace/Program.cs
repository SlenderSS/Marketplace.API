using ApiMarketplace.Database;
using ApiMarketplace.Models;
using ApiMarketplace.Repository;
using ApiMarketplace.Repository.Interface;
using ApiMarketplace.Services;
using ApiMarketplace.Services.ResponseService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




builder.Services.AddDbContext<MarketplaceContext>();
// Repositories
builder.Services.AddScoped<IBaseRepository<Basket>, BaseRepository<Basket>>();
builder.Services.AddScoped<IBaseRepository<BasketItem>, BaseRepository<BasketItem>>();
builder.Services.AddScoped<IBaseRepository<BlackList>, BaseRepository<BlackList>>();
builder.Services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
builder.Services.AddScoped<IBaseRepository<Order>, BaseRepository<Order>>();
builder.Services.AddScoped<IBaseRepository<OrderItem>, BaseRepository<OrderItem>>();
builder.Services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
builder.Services.AddScoped<IBaseRepository<Review>, BaseRepository<Review>>();
builder.Services.AddScoped<IBaseRepository<Role>, BaseRepository<Role>>();
builder.Services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();

//Service
builder.Services.AddScoped<IResponseService, ResponseService>();
builder.Services.AddScoped<ProductFilterSortService>();


var app = builder.Build();


// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
