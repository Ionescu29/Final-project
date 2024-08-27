using FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        private readonly StudentServices studentServices;
        public SeedController(StudentServices studentServices)
        {
            this.studentServices = studentServices;
        }
        [HttpPost]
        public void seed()
        {
            studentServices.AddStudent("Drelciuc", "Andrei", 20);
            studentServices.AddStudent("Cristea", "Ilie", 29);
            studentServices.AddStudent("Breniuc", "vlad", 24);
        }
    }
}
