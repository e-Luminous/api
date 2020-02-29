namespace api.Models
{
    public class StudentEnrollment
    {
        public Student Student { get; set; }

        public Classroom Classroom { get; set; }

        public string StudentId { get; set; }
        
        public string ClassroomId { get; set; }
    }
}