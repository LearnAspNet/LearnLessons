using Microsoft.AspNetCore.Mvc;
using LessonTwo.Domain.Interfaces;

namespace LessonTwo.Api.Controllers
{
    public class NewGuidController : Controller
    {
        readonly IServiceA serviceA;
        readonly IServiceB serviceB;
        readonly IServiceC serviceC;

        public NewGuidController(IServiceA serviceA, IServiceB serviceB, IServiceC serviceC)
        {
            this.serviceA = serviceA;
            this.serviceB = serviceB;
            this.serviceC = serviceC;
        }

        public string Services()
        {
            string services = $"{serviceA.GetService()} {serviceB.GetService()} {serviceC.GetService()}";
            return services;
        }        
    }
}
