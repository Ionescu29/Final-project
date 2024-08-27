using FinalProject.Data;
using FinalProject.DTO;
using FinalProject.Models;
using FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentServices studentServices;
        public StudentsController(RegistryStudentDbContext studentServices)
        {
            this.studentServices = studentServices;
        }


        [HttpPost]
        public void AddStudent([FromBody] StudentToCreateDTO studentToCreate) =>
            StudentServices.AddStudent(studentToCreate.Name, studentToCreate.FirstName, studentToCreate.Age);
        [HttpGet]
        public List<Student> GetAll() => StudentServices.GetAll();

    }
}
