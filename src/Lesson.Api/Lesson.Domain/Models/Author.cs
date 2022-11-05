using Lesson.Domain.Abstractions;

namespace Lesson.Domain.Models;

public class Author : Entity
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public List<Book>? Books { get; set; }
}
