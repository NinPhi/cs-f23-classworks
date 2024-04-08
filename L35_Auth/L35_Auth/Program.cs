using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var securityKey = Encoding.UTF8.GetBytes("SUPER SECURE CODe 1337 AZIM JKDLFVJFDILHVNLDFJVN;FDJV;LSJFV;LDJVFDLJV;LFDJB;LVJFL;B JLFJBL;");

builder.Services.AddAuthentication(opts =>
{
    opts.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    opts.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    opts.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(opts =>
{
    opts.MapInboundClaims = false;
    opts.SaveToken = false;
    opts.TokenValidationParameters = new()
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(securityKey),
        ValidateAudience = false,
        ValidateIssuer = false,
        RequireExpirationTime = true,
    };
});

//builder.Services.AddAuthentication()
//    .AddCookie("Cookies", opts =>
//{
//    opts.ExpireTimeSpan = TimeSpan.FromMinutes(30);

//    opts.Events.OnRedirectToLogin = (context) =>
//    {
//        context.Response.StatusCode = 401;
//        return Task.CompletedTask;
//    };

//    opts.Events.OnRedirectToAccessDenied = (context) =>
//    {
//        context.Response.StatusCode = 403;
//        return Task.CompletedTask;
//    };
//});

builder.Services.AddAuthorization(opts =>
{
    opts.FallbackPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
