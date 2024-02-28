using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace L24_EFCore_Navigation.Auth;

public static class AuthExtensions
{
    public static IServiceCollection AddAuth(this IServiceCollection services)
    {
        services.AddTransient<AuthService>();

        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, opts =>
            {
                opts.Cookie.SameSite = SameSiteMode.Strict;

                opts.Events.OnRedirectToLogin =
                    o =>
                    {
                        o.Response.StatusCode = 401;
                        return Task.CompletedTask;
                    };

                opts.Events.OnRedirectToAccessDenied =
                    o =>
                    {
                        o.Response.StatusCode = 403;
                        return Task.CompletedTask;
                    };
            });

        services.AddAuthorization(opts =>
        {
            opts.FallbackPolicy =
                new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
        });

        return services;
    }
}
