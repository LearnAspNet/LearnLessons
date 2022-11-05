using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Core.App.Services
{
    public class BService : IServiceB
    {
        public Guid ServiceBId { get; set; }
        Guid guid = Guid.NewGuid();

        public string GetService()
        {            
            ServiceBId = guid;
            return ServiceBId.ToString();
        }
    }
}
