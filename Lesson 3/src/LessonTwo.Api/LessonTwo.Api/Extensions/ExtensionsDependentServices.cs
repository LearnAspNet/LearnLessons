using LessonTwo.Domain.Interfaces;
using LessonTwo.Core.App.Services;

namespace LessonTwo.Api.Extensions

{
    public static class ExtensionsDependentServices
    {
        public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();

            builder.Services.AddTransient<IServiceA, AService>();
            builder.Services.AddScoped<IServiceB, BService>();
            builder.Services.AddSingleton<IServiceC, CService>();

            return builder;
        }
    }
}
