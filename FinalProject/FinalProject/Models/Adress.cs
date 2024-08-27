namespace FinalProject.Models
{
    public class Adress
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public Guid? StudentId { get; set; }
        public Student Student { get; set; }
    }
}
