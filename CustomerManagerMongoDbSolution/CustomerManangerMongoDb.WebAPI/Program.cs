using CustomerManagerMongoDb.Infrastructure;
using CustomerManagerMongoDb.Infrastructure.Repositories;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.Configure<Settings>(builder.Configuration.GetSection("CustomerDatabase"));

builder.Services.AddSingleton<ICustomerContext, CustomerContext>();
builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
