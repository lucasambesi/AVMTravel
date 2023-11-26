using AVMTravel.Tours.API.ApiClients.Extensions;
using AVMTravel.Tours.API.Bootstrap.Providers.Cofigurations;
using AVMTravel.Tours.API.Bootstrap.Providers.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationlayer();

builder.Services.AddPersistenceInfraestructure(builder.Configuration);

builder.Services.AddControllers();

//Services
builder.Services.ConfigureServices();
builder.Services.ConfigureValidators();

//MediaTR
builder.Services.ConfigureMediatrServices();

//Utils
builder.Services.AddMapper();

//ApiVersioning
builder.Services.AddVersioning();

//Authentication
builder.Services.AddApiAuthentication(builder.Configuration);

//Clients
builder.Services.AddAccommodationServiceClient(builder.Configuration);

//Swagger Gen /OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGenConfig();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API AVMTravel Tours", Version = "v1" });
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

app.RunMigrations();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API AVMTravel Tours V1");
});

app.UseHttpsRedirection();

app.UseApiAuthorization();

app.MapControllers();

app.Run();
