using Application;
using Domain.Modules.Scooters;
using L47P_MediatR.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IScooterRepository, ScooterRepository>();

builder.Services.AddMediatR(config =>
    config.RegisterServicesFromAssembly(ApplicationAssembly.Reference));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
