using AVMTravel.Accommodation.API.Repositories;
using AVMTravel.Accommodation.API.Repositories.Interfaces;
using AVMTravel.Accommodation.API.Services;
using AVMTravel.Accommodation.API.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IHotelService, HotelService>();
builder.Services.AddScoped<IHotelCollection, HotelCollection>();

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
