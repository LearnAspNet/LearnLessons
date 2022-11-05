using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Core.App.Services
{
    public class CService : IServiceC
    {
        public Guid ServiceCId { get; set; }

        public CService()
        {
            ServiceCId = Guid.NewGuid();
        }

        public string GetService()
        {
            return ServiceCId.ToString();
        }
    }
}
