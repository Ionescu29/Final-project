using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Services
{
    public class StudentServices
    {
        private readonly RegistryStudentDbContext ctx;
        public StudentServices(RegistryStudentDbContext ctx)
        {
            this.ctx = ctx;
        }
        public Student AddStudent(string name, string firstname, int age)
        {
            var student = ctx.Students.FirstOrDefault(x => x.Name == name);
            if (student != null)
            {
                return student;
            }
            var student = new Student { Name = name, Age = age };
            ctx.Students.Add(student);
            return student;
        }
        [HttpGet]
        List<Student> GetAll() => ctx.Students.ToList();

        public Student GetStudentByName(string Name) =>
             ctx.Students.FirstOrDefault(x => x.Name ==Name);
    }
}
