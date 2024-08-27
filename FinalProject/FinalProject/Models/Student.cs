namespace FinalProject.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Adress Adress { get; set; }
    }
}
