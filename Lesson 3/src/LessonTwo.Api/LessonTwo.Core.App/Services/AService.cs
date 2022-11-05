using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Core.App.Services
{
    public class AService : IServiceA
    {
        public Guid ServiceAId { get; set;}

        public AService()
        {
            ServiceAId = Guid.NewGuid();
        }

        public string GetService()
        {            
            return ServiceAId.ToString();
        }
    }
}
