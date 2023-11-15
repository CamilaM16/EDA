using Microsoft.AspNetCore.Mvc;
using service.Models;
using service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var settings = builder.Configuration.GetSection("DataBase");
builder.Services.Configure<EcommersDataBaseSettings>(settings);
builder.Services.AddSingleton<IService<UserModel>, UserService>();
builder.Services.AddSingleton<IService<CategoryModel>, CategoryService>();
builder.Services.AddSingleton<IService<Product>, ProductService>();
builder.Services.AddSingleton<IService<Invoice>, InvoiceService>();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
