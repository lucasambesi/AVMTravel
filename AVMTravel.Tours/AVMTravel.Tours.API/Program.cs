using AVMTravel.Tours.API.Bootstrap.Providers.Cofigurations;
using AVMTravel.Tours.API.Bootstrap.Providers.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationlayer();

builder.Services.AddPersistenceInfraestructure(builder.Configuration);

builder.Services.AddControllers();

//Services
builder.Services.ConfigureServices();

//MediaTR
builder.Services.ConfigureMediatrServices();

//Utils
builder.Services.AddMapper();

//ApiVersioning
builder.Services.AddVersioning();

//Swagger Gen /OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//app.RunMigrations();

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
