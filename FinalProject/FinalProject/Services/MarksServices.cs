using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Services
{
    public class MarksServices
    {
        private readonly RegistryStudentDbContext ctx;
        public MarksServices(RegistryStudentDbContext ctx)
        {
            this.ctx = ctx;
        }
        public Marks GetMarks(int id) =>
            ctx.Marks.FirstOrDefault(a => a.Id == id);
        public void ChangeStudentByMarks(Guid marksId, Guid studentId)
        {
            var mark = ctx.Marks.FirstOrDefault(a => a.Id == marksId);
            if (mark != null)
            {
                mark.StudentId = studentId;
            }
            ctx.SaveChanges();
        }
    }
}
