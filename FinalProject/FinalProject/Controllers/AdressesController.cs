using FinalProject.DTO;
using FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController : ControllerBase
    {
        private readonly StudentServices studestudentServices;
        private readonly AdressServices adressServices;
        public AdressesController(StudentServices studentServices, AdressServices adressServices)
        {
            this.studentServices = studentServices;
            this.adressServices = adressServices;
        }
        [HttpPost("add-student-to-adress/{adressId}")]
        public void AddStudentToAdress(int adressId, [FromBody] StudentToCreateDTO studentToCreate, [FromQuery] bool createIfNotExist = true)
        {
            var adress = adressServices.GetAdressById(adressId);
            if (adress == null)
            {
                return;
            }
        }

    }
}
