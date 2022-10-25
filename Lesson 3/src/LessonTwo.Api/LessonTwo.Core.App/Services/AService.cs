using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Core.App.Services
{
    public class AService : IServiceA
    {
        public Guid ServiceAId { get; set; }
        public string GetService()
        {
            Guid guid = Guid.NewGuid(); 
            return guid.ToString();
        }
    }
}
