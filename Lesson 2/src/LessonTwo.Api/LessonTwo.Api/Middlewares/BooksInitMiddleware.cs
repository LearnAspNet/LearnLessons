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
            
            var bookLibraryProp = myType.GetProperty("BookLibrary");

            bookLibraryProp?.SetValue
                (BookLibraryService.BooksLibrary, new List<Book>() { new Book(), new Book(), new Book(), new Book(), new Book() });
           
            await _next.Invoke(context);
            
        }
    }
}
