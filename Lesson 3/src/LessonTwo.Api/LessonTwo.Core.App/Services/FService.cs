using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Core.App.Services
{
    public class FService
    {
        AService _AService = new AService();
        BService _BService = new BService();
        CService _CService = new CService();
        public FService(AService serviceA, BService serviceB, CService serviceC)
        {
            this._AService = serviceA;
            this._BService = serviceB;
            this._CService = serviceC;
        }
        public string GetServices()
        {
            return $"TransientGuid: {_AService.ServiceAId} \nScopedGuid: {_BService.ServiceBId} \nSingletonGuid: {_CService.ServiceCId}";
        }
    }
}
