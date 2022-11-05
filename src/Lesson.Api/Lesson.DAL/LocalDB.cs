using Lesson.Domain.Models;

namespace Lesson.DAL;

public static class LocalDB
{
    /// <summary>
    /// База книг
    /// </summary>
    public static List<Book> Books { get; set; } = new ();

    /// <summary>
    /// База авторов
    /// </summary>
    public static List<Author> Authors { get; set; } = new ();
}

