using FinalProject.Data;
using FinalProject.Models;
using FinalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkController : ControllerBase
    {
        private readonly MarksServices marksServices;
        public MarkController(RegistryStudentDbContext marksServices)
        {
            this.marksServices = marksServices;
        }
        [HttpPost]
        public void AddMarks(Marks marksToCreate) =>
            SubjectServices.AddSubject(marksToCreate.Mark);
        [HttpGet]
        public List<Marks> GetAll() => MarksServices.GetAll();
        
    }
}
