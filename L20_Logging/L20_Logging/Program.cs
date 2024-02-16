using Serilog;
using Serilog.Events;

// Verbose
// Debug
// Trace (нет в Serilog)
// Information
// Warning
// Error
// Critical (в Serilog - Fatal)

var builder = WebApplication.CreateBuilder(args);

var config = new LoggerConfiguration();

//var logger = config
//    .MinimumLevel.Information()
//    .MinimumLevel.Override(
//        "Microsoft.AspNetCore",
//        LogEventLevel.Warning)
//    .WriteTo.Console()
//    .WriteTo.File("logs/log-.txt", 
//        rollingInterval: RollingInterval.Day)
//    .CreateLogger();

var logger = config
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.WithProperty("Dima", "Vinogradov")
    .Enrich.FromLogContext()
    .CreateLogger();

//Log.Logger = logger;

builder.Logging.ClearProviders();
builder.Services.AddSerilog(logger);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSerilogRequestLogging(opts =>
{
    opts.Logger = logger;
    opts.GetLevel = (ctx, _, ex) =>
    {
        if (ctx.Response.StatusCode is >= 400 and <= 499)
            return LogEventLevel.Error;

        return LogEventLevel.Information;
    };
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
