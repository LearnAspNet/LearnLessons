using Microsoft.AspNetCore.Mvc;
using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewGuidController : ControllerBase
    {
        private readonly IServiceA _serviceA;
        private readonly IServiceB _serviceB;
        private readonly IServiceC _serviceC;

        public NewGuidController(IServiceA serviceA, IServiceB serviceB, IServiceC serviceC)
        {
            this._serviceA = serviceA;
            this._serviceB = serviceB;
            this._serviceC = serviceC;
        }

        [Route("services")]
        public string Services()
        {
            string services = $"{_serviceA.GetService()} {_serviceB.GetService()} {_serviceC.GetService()}";
            return services;
        }        
    }
}
