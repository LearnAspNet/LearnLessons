using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Core.App.Services
{
    public class BService : IServiceB
    {
        public Guid ServiceBId { get; set; }
        public string GetService() => ServiceBId.ToString();
    }
}
