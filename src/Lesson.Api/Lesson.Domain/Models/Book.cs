using Lesson.Domain.Abstractions;

namespace Lesson.Domain.Models;

public class Book : Entity
{
    /// <summary>
    /// Название книги.
    /// </summary>
    public string Name { get; set; } = String.Empty;

    /// <summary>
    /// Описание книги. 
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Регистрационный номер книги.
    /// </summary>
    public Guid RegistrationNumber { get; set; }

    /// <summary>
    /// Авторы книги
    /// </summary>
    public List<Author>? Authors { get; set; }
}
