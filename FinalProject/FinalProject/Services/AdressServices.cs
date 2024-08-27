using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Services
{
    public class AdressServices
    {
        private readonly RegistryStudentDbContext ctx;
        public AdressServices(RegistryStudentDbContext ctx)
        {
            this.ctx = ctx;
        }
        public Adress GetAdressById(int id) =>
            ctx.Adresses.FirstOrDefault(a => a.Id == id);
        public void ChangeStudent(int adressId, Guid studentId)
        {
            var adress = ctx.Adresses.FirstOrDefault(a => a.Id == adressId);
                if (adress != null)
            {
                adress.StudentId = studentId;
            }
            ctx.SaveChanges();
        }
    }
}
