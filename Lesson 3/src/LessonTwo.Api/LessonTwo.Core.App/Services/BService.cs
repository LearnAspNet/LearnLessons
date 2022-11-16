using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Core.App.Services
{
    public class BService : IServiceB
    {
        public Guid ServiceBId { get; set; }

        public BService()
        {
            ServiceBId = Guid.NewGuid();
        }

        public string GetService()
        {
            return ServiceBId.ToString();
        }
    }
}
