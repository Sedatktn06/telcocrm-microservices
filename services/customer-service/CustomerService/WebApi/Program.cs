using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CustomerDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("CustomerContextConnection"),npgsql =>
    {
        npgsql.MigrationsAssembly(typeof(CustomerDbContext).FullName);
    }).UseSnakeCaseNamingConvention()
    );

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
