using LessonTwo.Api.Controllers;
using Serilog;

namespace LessonTwo.Api.Middlewares
{
    public class GuidMiddleware
    {
        private readonly RequestDelegate _next;

        NewGuidController newGuidController;

        public GuidMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if(context.Request.Path == "/api/[controller]/services")
            {
                context.Response.StatusCode = 200;
                context.Response.ContentType = "text/plain;charset=utf-8";
                await context.Response.WriteAsync($"{newGuidController.Services}");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
