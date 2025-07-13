using CleanArchitecture.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("SqlServer");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer("connectionString"));

builder.Services.AddControllers()
    .AddApplicationPart(typeof(CleanArchitecture.Presentation.AssemblyReference).Assembly);
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
