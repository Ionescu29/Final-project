using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace FinalProject.Services
{
    public class SubjectServices
    {
        private readonly RegistryStudentDbContext ctx;
        public SubjectServices (RegistryStudentDbContext ctx)
        {
            this.ctx = ctx;
        }
        public Subject AddSubject(string NameOfSubject)
        {
            var subject = ctx.Subjects.FirstOrDefault(x => x.NameOfSubject == NameOfSubject);
            if (subject!=null)
            {
                return subject;
            }
            var subject = new Subject { NameOfSubject = NameOfSubject };
            ctx.Subjects.Add(subject);
        }
        [HttpGet]
        List<Subject> GetAll() => ctx.Subjects.ToList();
    }
}
