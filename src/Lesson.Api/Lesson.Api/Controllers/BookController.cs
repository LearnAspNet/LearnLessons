using Lesson.Core.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lesson.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public async Task<IActionResult> GetBooks()
        {
            return await Task.FromResult(Ok(BookLibraryService.BooksLibrary));
        } 
    }
}
