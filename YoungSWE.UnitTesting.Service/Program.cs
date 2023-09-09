using YoungSWE.UnitTesting.Service;
using YoungSWE.UnitTesting.Infrastructure.Interfaces;
using YoungSWE.UnitTesting.Repository.Interfaces;
using YoungSWE.UnitTesting.Repository.Implementation;
using YoungSWE.UnitTesting.Domain.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IExampleService, ExampleService>();
builder.Services.AddScoped<IExampleRepo, ExampleRepo>();
builder.Services.AddDbContext<ExampleContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("ExampleDatabase"))
);
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
