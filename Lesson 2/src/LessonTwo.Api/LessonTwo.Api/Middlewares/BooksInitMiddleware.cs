using LessonTwo.Core.App.Services;
using LessonTwo.Domain.Models;
using System.Reflection;

namespace LessonTwo.Api.Middlewares
{
    public class BooksInitMiddleware
    {
        private readonly RequestDelegate _next;

        public BooksInitMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Type myType = typeof(BookLibraryService);
            Book book = new Book();

            var nameBookProp = myType.GetProperty("Name");
            var titleBookProp = myType.GetProperty("Title");
            var registrationNumberProp = myType.GetProperty("RegistrationNumber");

            var name = new List<string>() { "Name1", "Name2", "Name3", "Name4", "Name5" };
            var title = new List<string>() { "Title1", "Title2", "Title3", "Title4", "Title5" };

            for(int i = 0; i < 5; i++)
            {
                nameBookProp?.SetValue(book, $"{name[i]}");
                titleBookProp?.SetValue(book, $"{title[i]}");
            }
           
            await _next.Invoke(context);
            
        }
    }
}
