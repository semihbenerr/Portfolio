using Microsoft.AspNetCore.Http;
using System.Net;
using System.Threading.Tasks;

namespace MyPortfolio.WebUI.Middlewares
{
    public class IpRestrictionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string[] _allowedIps;

        public IpRestrictionMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _allowedIps = configuration.GetSection("AllowedAdminIPs").Get<string[]>() ?? new string[0];
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/admin"))
            {
                var remoteIp = context.Connection.RemoteIpAddress?.ToString();
                if (!_allowedIps.Contains(remoteIp))
                {
                    context.Response.StatusCode = StatusCodes.Status403Forbidden;
                    await context.Response.WriteAsync("Access Denied: Your IP is not allowed.");
                    return;
                }
            }
            await _next(context);
        }
    }
}