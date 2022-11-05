using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Core.App.Services
{
    public class FService : IServiceF
    {
        private readonly IServiceA _serviceA;
        private readonly IServiceB _serviceB;
        private readonly IServiceC _serviceC;

        public FService(IServiceA serviceA, IServiceB serviceB, IServiceC serviceC)
        {
            this._serviceA = serviceA;
            this._serviceB = serviceB;
            this._serviceC = serviceC;
        }

        public string GetServices()
        {
            return $"TransientGuid: {_serviceA.GetService()} \nScopedGuid: {_serviceB.GetService()} \nSingletonGuid: {_serviceC.GetService()}";
        }
    }
}
