using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Core.App.Services
{
    public class CService : IServiceC
    {
        public Guid ServiceCId { get; set; }

        public string GetService()
        {
            Guid guid = Guid.NewGuid();
            ServiceCId = guid;
            return guid.ToString();
        }
    }
}
