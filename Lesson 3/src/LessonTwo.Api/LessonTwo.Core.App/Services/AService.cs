using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Core.App.Services
{
    public class AService : IServiceA
    {
        public Guid ServiceAId { get; set;}
        Guid guid = Guid.NewGuid();

        public string GetService()
        {            
            ServiceAId = guid;
            return ServiceAId.ToString();
        }
    }
}
