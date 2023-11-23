using AVMTravel.Tours.API.Bootstrap.Providers.Cofigurations;
using AVMTravel.Tours.API.Bootstrap.Providers.Extensions;
using Swashbuckle.AspNetCore.SwaggerGen;

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

//Authentication
builder.Services.AddApiAuthentication(builder.Configuration);

//Swagger Gen /OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGenConfig();

builder.Services.Configure<SwaggerGenOptions>(options =>
{
    options.CustomSchemaIds(x => x.FullName);
    options.UseAllOfToExtendReferenceSchemas();
});

var app = builder.Build();

//app.RunMigrations();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseApiAuthorization();

app.MapControllers();

app.Run();
