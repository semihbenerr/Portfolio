using Microsoft.AspNetCore.Http;
using System.Net;
using System.Threading.Tasks;

namespace MyPortfolio.WebUI.Middlewares
{
    public class IpRestrictionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string[] _allowedIps;

        public IpRestrictionMiddleware(RequestDelegate next)
        {
            _next = next;

            _allowedIps = new[] { "172.23.16.1", "192.168.0.15" };
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var remoteIp = context.Connection.RemoteIpAddress;
            var path = context.Request.Path.ToString().ToLower();

            if (path.StartsWith("/admin"))
            {
                var bytes = remoteIp.GetAddressBytes();
                bool isAllowed = false;

                foreach (var address in _allowedIps)
                {
                    var testIp = IPAddress.Parse(address);
                    if (testIp.GetAddressBytes().Length == bytes.Length)
                    {
                        if (remoteIp.Equals(testIp))
                        {
                            isAllowed = true;
                            break;
                        }
                    }
                }

                if (!isAllowed)
                {
                    context.Response.StatusCode = 403;
                    await context.Response.WriteAsync("Access Denied: Your IP is not allowed to access this area.");
                    return;
                }
            }

            await _next(context);
        }
    }
}