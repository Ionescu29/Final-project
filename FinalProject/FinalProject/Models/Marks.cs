namespace FinalProject.Models
{
    public class Marks
    { 
        public Guid Id { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }
        public Guid? StudentId { get; set; }
        public Student Student { get; set; }
        public Guid? SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
