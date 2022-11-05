using Microsoft.AspNetCore.Mvc;
using LessonTwo.Domain.Interfaces;
using LessonTwo.Core.App.Services;

namespace LessonTwo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewGuidController : ControllerBase
    {
        private readonly IServiceA _serviceA;
        private readonly IServiceB _serviceB;
        private readonly IServiceC _serviceC;
        private readonly FService _serviceF;

        public NewGuidController(IServiceA serviceA, IServiceB serviceB, IServiceC serviceC, FService serviceF)
        {
            this._serviceA = serviceA;
            this._serviceB = serviceB;
            this._serviceC = serviceC;
            this._serviceF = serviceF;
        }

        [Route("services")]
        public string Services()
        {
            string services = $"TransientGuid: {_serviceA.GetService()} \nScopedGuid: {_serviceB.GetService()} \nSingletonGuid: {_serviceC.GetService()} \nFService:{_serviceF.GetServices()}";
            return services;
        }        
    }
}
