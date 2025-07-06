using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyApi.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomHeaderMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomHeaderMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {

            httpContext.Response.Headers["X-Custom-Header"] = "HelloFromMiddleware";

            await _next(httpContext);

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CustomHeaderMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomHeaderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomHeaderMiddleware>();
        }
    }
}
