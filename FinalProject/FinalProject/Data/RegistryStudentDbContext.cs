using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class RegistryStudentDbContext
    {
        protected RegistryStudentDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ionut\source\repos\Lab17Ex1\Lab17Ex1\ProductDb.mdf;Integrated Security=True");
        base.OnConfiguring(optionsBuilder);
    }
}
}
