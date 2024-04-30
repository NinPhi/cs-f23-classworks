using L47P_MediatR;
using Application.Features.Scooters.GetAll;
using Domain.Modules.Scooters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MediatR;
using Application;

var builder = Host.CreateDefaultBuilder();

builder.ConfigureServices(s =>
{
    s.AddScoped<IScooterRepository, ScooterRepository>();

    s.AddMediatR(config =>
    {
        config.RegisterServicesFromAssembly(ApplicationAssembly.Reference);
    });
});

var app = builder.Build();

var mediator = app.Services.GetRequiredService<IMediator>();

var request = new GetAllScootersQuery();

var scooters = await mediator.Send(request);

scooters.ForEach(s => Console.WriteLine(s.CringePhrase));

app.Run();
