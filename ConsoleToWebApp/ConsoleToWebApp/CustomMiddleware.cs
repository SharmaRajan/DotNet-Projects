using System;

namespace ConsoleToWebApp
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from CustomMiddleware -1\n");
            await next(context);
            await context.Response.WriteAsync("Hello from CustomMiddleware -2\n");
        }
    }
}

