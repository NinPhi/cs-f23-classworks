using L17_DependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<UserService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddTransient<UserService>();

if (builder.Configuration.GetValue<bool>("UseDb"))
{
    builder.Services.AddTransient<IUserService, DbUserService>();
}
else
{
    builder.Services.AddTransient<IUserService, UserService>();
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
