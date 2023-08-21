using BlazorAssembly.API.Data;
using Microsoft.EntityFrameworkCore;
using BlazorAssembly.API.Extensions;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Build().MigrateDbContext<BlazorDbContext>((context, service) =>
{
    var logger = service.GetService<ILogger<BlazorDbContext>>();
    new SeedData().SeedAsync(context, logger).Wait();
}).Run();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BlazorDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? 
    throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));



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
