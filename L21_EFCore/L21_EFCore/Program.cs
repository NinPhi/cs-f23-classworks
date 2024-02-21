using L21_EFCore;
using L21_EFCore.Data;
using L21_EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//Console.WriteLine("App started!");

//using var context = new AppDbContext();

////var auto = new Auto()
////{
////    Model = "Spark",
////    Brand = "Chevrolet",
////    EngineVolume = 1500,
////    Price = 1100000,
////};

////await context.Autos.AddAsync(auto);

////await context.SaveChangesAsync();

//var auto = await context.Autos.FirstAsync();

//Console.WriteLine($"Model = {auto.Model} was created under ID = {auto.Id}");

//Console.WriteLine("App finished!");

var builder = Host.CreateDefaultBuilder();

builder.ConfigureServices(services =>
{
    services.AddDbContext<AppDbContext>();
    services.AddHostedService<App>();
});

var host = builder.Build();

host.Run();