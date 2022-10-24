using LessonTwo.Domain.Models;

namespace LessonTwo.Core.App.Services;

public static class BookLibraryService 
{
    /// <summary>
    /// Библиотека книг.
    /// </summary>
    public static List<Book> BooksLibrary { get; set; } = new List<Book>();
}

