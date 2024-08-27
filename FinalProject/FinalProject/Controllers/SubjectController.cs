using FinalProject.Data;
using FinalProject.Models;
using FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly SubjectServices subjectServices;
        public SubjectController(RegistryStudentDbContext subjectServices)
        {
            this.subjectServices = subjectServices;
        }
        [HttpPost]
        public void AddSubject(Subject subjecttocreate) =>
            SubjectServices.AddSubject(subjecttocreate.NameOfSubject);
        [HttpGet]
        public List<Subject> GetAll() => SubjectServices.GetAll();
        


    }
}
