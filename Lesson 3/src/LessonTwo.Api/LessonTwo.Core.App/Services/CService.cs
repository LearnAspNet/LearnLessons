using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Core.App.Services
{
    public class CService : IServiceC
    {
        public Guid ServiceCId { get; set; }
        Guid guid = Guid.NewGuid();

        public string GetService()
        {
            ServiceCId = guid;
            return ServiceCId.ToString();
        }
    }
}
